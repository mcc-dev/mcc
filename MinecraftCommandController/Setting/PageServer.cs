using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftCommandController.Setting
{
	public partial class PageServer : UserControl
	{
		private AppSettingForm settingForm;

		private void init()
		{
			textBox1.Text = settingForm.settings.McDir;
			checkBox1.Checked = settingForm.settings.UseServer;
			textBox2.Text = settingForm.settings.ServerFile;
			textBox3.Text = settingForm.settings.ServerArg;
			textBox4.Text = settingForm.settings.JavaDir;
		}

		public void fncSetData()
		{
			settingForm.settings.McDir = textBox1.Text;
			settingForm.settings.UseServer = checkBox1.Checked;
			settingForm.settings.ServerFile = textBox2.Text;
			settingForm.settings.ServerArg = textBox3.Text;
			settingForm.settings.JavaDir = textBox4.Text;
		}

		public PageServer(AppSettingForm form)
		{
			this.settingForm = form;
			InitializeComponent();
		}

		public PageServer()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.Description = @"Minecraftサーバーのあるフォルダを選択";
			folderBrowserDialog1.ShowNewFolderButton = true;
			folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				textBox1.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = textBox1.Text;
			openFileDialog1.Filter = "jarファイル(*.jar)|*.jar|すべてのファイル(*.*)|*.*";
			openFileDialog1.Title = "実行するファイルを選択してください";
			//ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
			openFileDialog1.RestoreDirectory = true;
			//ダイアログを表示する
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				//OKボタンがクリックされたとき、選択されたファイル名を表示する
				textBox2.Text = openFileDialog1.FileName;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			folderBrowserDialog2.Description = @"Java実行環境フォルダを選択";
			folderBrowserDialog2.ShowNewFolderButton = true;
			folderBrowserDialog2.RootFolder = Environment.SpecialFolder.MyComputer;
			if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
			{
				textBox4.Text = folderBrowserDialog2.SelectedPath;
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				groupBox2.Enabled = true;
			}
			else
			{
				groupBox2.Enabled = false;
			}
		}

		private void PageServer_Load(object sender, EventArgs e)
		{
			init();
		}
	}
}
