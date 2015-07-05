using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace CommandController
{
	public partial class MvWorldList : UserControl
	{
		private AppMainForm refForm;

		public MvWorldList()
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

		private void button1_Click(object sender, EventArgs e)
		{
			string sFilePath = refForm.appSettings.McDir + @"\plugins\Multiverse-Core\worlds.yml";
			if (!File.Exists(sFilePath))
			{
				MessageBox.Show("設定ファイルが見つかりません。");
				return;
			}
			// YAMLのファイルをUTF-8エンコーディングされたファイルとして読み込む
			StreamReader reader = new StreamReader(sFilePath, Encoding.UTF8);

			listBox1.Items.Clear();
			// 読み込みできる文字がなくなるまで繰り返す
			while (reader.Peek() >= 0)
			{
				// ファイルを 1 行ずつ読み込む
				string sBuffer = reader.ReadLine();
				// ワールド名を抜き出してリストに追加
				Regex reg = new Regex(@"^ {2}\S");
				if (reg.IsMatch(sBuffer))
				{
					reg = new Regex(@"^ {2}(?<key>\w+):");
					Match m = reg.Match(sBuffer);
					Console.WriteLine(m.Groups["key"].Value);
					listBox1.Items.Add(m.Groups["key"].Value);
				}
			}

			// reader を閉じる (オブジェクトの破棄を保証する)
			reader.Close();
		}
	}
}
