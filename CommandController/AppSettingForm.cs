using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandController
{
	public partial class AppSettingForm : Form
	{
		AppMainForm f1;

		public AppSettingForm(AppMainForm f)
		{
			f1 = f;
			InitializeComponent();
			init();
		}

		private void init() {
			textBox2.Text = f1.appSettings.MyID;
			textBox1.Text = f1.appSettings.McDir;
			checkBox1.Checked = f1.appSettings.UseServer;

			if (f1.appSettings.FlgDebug) {
				radioButton4.Visible = true;
			}

			if (f1.appSettings.ExcuteType == 1)
			{
				radioButton1.Checked = true;
			}
			else if (f1.appSettings.ExcuteType == 2)
			{
				radioButton2.Checked = true;
			}
			else if (f1.appSettings.ExcuteType == 3)
			{
				radioButton3.Checked = true;
			}
			else if (f1.appSettings.ExcuteType == 4)
			{
				radioButton4.Checked = true;
			}

			checkBox2.Checked = f1.appSettings.FlgExcute ? false : true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.Description = @"Minecraftサーバーのあるフォルダを選択";
			this.folderBrowserDialog1.ShowNewFolderButton = true;
			this.folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.Text = this.folderBrowserDialog1.SelectedPath;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			//設定値反映
			f1.appSettings.MyID = textBox2.Text;
			f1.appSettings.McDir = textBox1.Text;
			f1.appSettings.FlgExcute = checkBox2.Checked ? false : true;
			f1.appSettings.UseServer = checkBox1.Checked;
			if (radioButton1.Checked)
			{
				f1.appSettings.ExcuteType = 1;
			}
			else if (radioButton2.Checked)
			{
				f1.appSettings.ExcuteType = 2;
			}
			else if (radioButton3.Checked)
			{
				f1.appSettings.ExcuteType = 3;
			}
			else if (radioButton4.Checked)
			{
				f1.appSettings.ExcuteType = 4;
			}
			
			f1.SaveSettings();
			this.Close();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			//実行タイプの有効化、無効か
			if (checkBox1.Checked)
			{
				radioButton2.Enabled = true;
				radioButton3.Enabled = true;
			}
			else
			{
				radioButton2.Enabled = false;
				radioButton3.Enabled = false;
				radioButton1.Checked = true;
			}
		}
	}
}
