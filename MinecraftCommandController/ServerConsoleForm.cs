using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using MinecraftCommandController.Daos;

namespace MinecraftCommandController
{
	public partial class ServerConsoleForm : Form
	{
		private AppMainForm appMainForm;
		private Process p = new Process();

		public ServerConsoleForm(AppMainForm form)
		{
			InitializeComponent();
			appMainForm = form;
			init();
		}
		private void init()
		{
			//出力をストリームに書き込むようにする
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
			//OutputDataReceivedイベントハンドラを追加
			p.OutputDataReceived += p_OutputDataReceived;
			p.ErrorDataReceived += p_ErrorDataReceived;
			//プロセス終了時のイベントハンドラを追加
			p.EnableRaisingEvents = true;
			p.Exited += new EventHandler(p_Exited);

			p.StartInfo.FileName = Environment.GetEnvironmentVariable("ComSpec");
			p.StartInfo.RedirectStandardInput = true;
			p.StartInfo.RedirectStandardOutput = true;
			p.StartInfo.RedirectStandardError = true;
			p.StartInfo.CreateNoWindow = true;

			//起動
			p.Start();
		}

		//OutputDataReceivedイベントハンドラ
		//行が出力されるたびに呼び出される
		private void p_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			Invoke(new OutLogDelegate(OutLog), e.Data);
		}

		private void p_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
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

		public void fncExecuteCommand(string cmd)
		{
			p.StandardInput.WriteLine(cmd);
		}

		//デザイナーからの半自動生成
		public ServerConsoleForm()
		{
			InitializeComponent();
			init();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//マインクラフトサーバー起動
			p.StandardInput.WriteLine("cd " + SettingDao.ReferSettings().McDir);
			p.StandardInput.WriteLine(
				"\"" + SettingDao.ReferSettings().JavaDir + "\\java\" " +
				SettingDao.ReferSettings().ServerArg +
				" -jar \"" + SettingDao.ReferSettings().ServerFile + "\""
				);

			button1.Enabled = false;
			button2.Enabled = true;
			textBox1.Enabled = true;

			AppSession.isRunningServer = true;
			appMainForm.fncApplySettings();
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
				if (cmd == "stop")
				{
					MessageBox.Show("サーバーの停止は上のボタンから行ってください。");
					return;
				}
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

			//非同期で出力の読み取りを終了
			//p.CancelOutputRead();
			//p.CancelErrorRead();

			AppSession.isRunningServer = false;
			appMainForm.fncApplySettings();
		}

		private void ServerConsoleForm_Load(object sender, EventArgs e)
		{
			//非同期で出力の読み取りを開始
			p.BeginOutputReadLine();
			p.BeginErrorReadLine();
		}

		private void ServerConsoleForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				// × ボタンの場合は、Hide に変える。
				e.Cancel = true;
				this.Hide();
			}
		}
	}
}
