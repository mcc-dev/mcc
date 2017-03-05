using System;
using System.IO;
using System.Windows.Forms;

using MinecraftCommandController.Base;

namespace MinecraftCommandController.Contents.Skript
{
	public partial class SkList : MccContentPageBase
	{
		private AppMainForm appMainForm;

		public SkList(AppMainForm form)
		{
			InitializeComponent();
			this.appMainForm = form;
			init();
		}

		private void init()
		{
			fncGetSkriptList();
		}

		public void fncGetSkriptList()
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();

			string skDir = appMainForm.settings.McDir + @"\plugins\Skript\scripts";
			if (Directory.Exists(skDir))
			{
				string[] files = Directory.GetFiles(skDir, "*.sk");
				foreach (string s in files)
				{
					string strFileName = Path.GetFileNameWithoutExtension(s);
					if (strFileName.StartsWith("-"))
					{
						listBox1.Items.Add(strFileName.Substring(1));
					}
					else
					{
						listBox2.Items.Add(strFileName);
					}
				}
				listBox1.Sorted = true;
				listBox2.Sorted = true;
			}
		}

		//デザイナーからの半自動生成
		public SkList()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			fncGetSkriptList();
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string strSelName = listBox1.SelectedItem.ToString();
			listBox2.Items.Add(strSelName);
			listBox2.Sorted = true;
			listBox1.Items.Remove(strSelName);
			string cmd = "skript enable " + strSelName;
			appMainForm.fncExecuteCommand(cmd);
		}

		private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string strSelName = listBox2.SelectedItem.ToString();
			listBox1.Items.Add(strSelName);
			listBox1.Sorted = true;
			listBox2.Items.Remove(strSelName);
			string cmd = "skript disable " + strSelName;
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string cmd = "skript reload all";
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string cmd = "skript reload config";
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string cmd = "skript reload aliases";
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string cmd = "skript reload scripts";
			appMainForm.fncExecuteCommand(cmd);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedItem == null)
			{
				MessageBox.Show("有効中のスクリプトを選択してください。");
				return;
			}
			string strSelName = listBox2.SelectedItem.ToString();
			string cmd = "skript reload " + strSelName;
			appMainForm.fncExecuteCommand(cmd);
		}
	}
}
