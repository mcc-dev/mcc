using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CommandController
{
	public partial class HeDataBase : UserControl
	{
		private AppMainForm refForm;

		public HeDataBase()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
			fncInit();
		}

		private void fncInit()
		{

		}

		private void fncExecuteQuery(string sql)
		{
			string server = refForm.appSettings.HeServer;
			string database = refForm.appSettings.HeDataBase;
			string user = refForm.appSettings.HeUser;
			string pass = refForm.appSettings.HePass;

			string myConnectionString = string.Format(
				"Server={0};Database={1};Uid={2};Pwd={3}",
				server,
				database,
				user,
				pass);

			using (var connection = new MySqlConnection(myConnectionString))
			{
				try
				{
					connection.Open();
					var cmd = connection.CreateCommand();
					cmd.CommandText = sql;
					// データを格納するテーブル作成
					DataTable dt = new DataTable();
					// SQL文と接続情報を指定し、データアダプタを作成
					MySqlDataAdapter da = new MySqlDataAdapter(cmd);
					// データ取得
					da.Fill(dt);
					// データ表示
					dataGridView1.DataSource = dt;

					connection.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error : " + ex.Message);
					MessageBox.Show("データベースに接続できませんでした。接続設定を確認してください。");
				}
				Console.ReadLine();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			fncExecuteQuery("SELECT * FROM hawk_players ORDER BY player_id ASC");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			fncExecuteQuery("SELECT * FROM hawkeye ORDER BY data_id DESC LIMIT 1000");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			fncExecuteQuery("SELECT * FROM hawk_worlds ORDER BY world_id ASC");
		}
	}
}
