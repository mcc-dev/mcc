using System;
using System.Diagnostics;
using System.Windows.Forms;

using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;

namespace MinecraftCommandController.Minecraft
{
	public partial class McServerConsole : UserControl
	{
		private AppMainForm appMainForm;

		Process p = new Process();

		public McServerConsole(AppMainForm form)
		{
			this.appMainForm = form;
			InitializeComponent();
			init();
		}

		private void init()
		{
			//出力をストリームに書き込むようにする
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			//OutputDataReceivedイベントハンドラを追加
			p.OutputDataReceived += p_OutputDataReceived;
			//プロセス終了時のイベントハンドラを追加
			p.EnableRaisingEvents = true;
			p.Exited += new EventHandler(p_Exited);

			p.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.CreateNoWindow = true;

			//起動
			p.Start();

			//非同期で出力の読み取りを開始
			p.BeginOutputReadLine();

		}

		//OutputDataReceivedイベントハンドラ
		//行が出力されるたびに呼び出される
		private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			//Console.WriteLine(e.Data);
			Invoke(new OutLogDelegate(OutLog), e.Data);
		}

		private void p_Exited(object sender, EventArgs e)
		{
			p.WaitForExit();
			p.Close();
		}

		//出力ログデリゲート
		delegate void OutLogDelegate(string output);
		private void OutLog(string output)
		{
			if (output == null)
			{
				return;
			}
			//出力された文字列を表示する
			textBox2.AppendText(output + "\r\n");
			textBox2.SelectionStart = textBox2.Text.Length;
			textBox2.ScrollToCaret();
		}

		//デザイナーからの半自動生成
		public McServerConsole()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SettingEt setting = SettingDao.ReferSettings();

			//マインクラフトサーバー起動
			p.StandardInput.WriteLine("cd " + setting.McDir);
			p.StandardInput.WriteLine(
				"\"" + setting.JavaDir + "\\java\" " +
				setting.ServerArg +
				" -jar \"" + setting.ServerFile + "\""
				);

			button1.Enabled = false;
			button2.Enabled = true;
			textBox1.Enabled = true;
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
			}
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			//押されたキーがエンターキーかどうかの条件分岐
			if (e.KeyCode == Keys.Enter)
			{
				string cmd = textBox1.Text;
				textBox1.Clear();
				p.StandardInput.WriteLine(cmd);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button1.Enabled = true;
			button2.Enabled = false;
			textBox1.Enabled = false;

			//マインクラフトサーバー停止
			p.StandardInput.WriteLine("stop");
		}
	}
}
