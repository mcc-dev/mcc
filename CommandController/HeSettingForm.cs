using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CommandController
{
	public partial class HeSettingForm : Form
	{
		AppMainForm f1;

		public HeSettingForm(AppMainForm f)
		{
			f1 = f;
			InitializeComponent();
			init();
		}

		private void init()
		{
			textBox1.Text = f1.appSettings.HeServer;
			textBox2.Text = f1.appSettings.HeDataBase;
			textBox3.Text = f1.appSettings.HeUser;
			textBox4.Text = f1.appSettings.HePass;
		}

		//OK
		private void button1_Click(object sender, EventArgs e)
		{
			f1.appSettings.HeServer = textBox1.Text;
			f1.appSettings.HeDataBase = textBox2.Text;
			f1.appSettings.HeUser = textBox3.Text;
			f1.appSettings.HePass = textBox4.Text;

			f1.SaveSettings();
			this.Close();
		}

		//キャンセル
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		//接続確認
		private void button3_Click(object sender, EventArgs e)
		{
			string server = textBox1.Text;
			string database = textBox2.Text;
			string user = textBox3.Text;
			string pass = textBox4.Text;

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
					cmd.CommandText = "SELECT * FROM hawk_players LIMIT 1";
					var dataAdapter = new MySqlDataAdapter(cmd);
					connection.Close();
					MessageBox.Show("接続の確認がとれました。");
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error : " + ex.Message);
					MessageBox.Show("接続できませんでした。接続設定をもう一度確認してください。");
				}
				Console.ReadLine();
			}
		}
	}
}
