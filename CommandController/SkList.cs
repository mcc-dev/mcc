using System;
using System.IO;
using System.Windows.Forms;

namespace CommandController
{
	public partial class SkList : UserControl
	{
		private AppMainForm refForm;
		public string mcDir = @"";

		public SkList()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
			fncGetSkriptList();
		}

		public void fncGetSkriptList()
		{
			listBox1.Items.Clear();
			listBox2.Items.Clear();

			string skDir = refForm.appSettings.McDir + @"\plugins\Skript\scripts";
			if (System.IO.Directory.Exists(skDir))
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
			string strOutput = "skript enable " + strSelName;
			refForm.fncExecuteCommand(strOutput);
		}

		private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string strSelName = listBox2.SelectedItem.ToString();
			listBox1.Items.Add(strSelName);
			listBox1.Sorted = true;
			listBox2.Items.Remove(strSelName);
			string strOutput = "skript disable " + strSelName;
			refForm.fncExecuteCommand(strOutput);
		}

		//全て
		private void button2_Click(object sender, EventArgs e)
		{
			string strOutput = "skript reload all";
			refForm.fncExecuteCommand(strOutput);
		}

		//コンフィグ
		private void button3_Click(object sender, EventArgs e)
		{
			string strOutput = "skript reload config";
			refForm.fncExecuteCommand(strOutput);
		}

		//エリアス
		private void button4_Click(object sender, EventArgs e)
		{
			string strOutput = "skript reload aliases";
			refForm.fncExecuteCommand(strOutput);
		}

		//スクリプト(全体)
		private void button5_Click(object sender, EventArgs e)
		{
			string strOutput = "skript reload scripts";
			refForm.fncExecuteCommand(strOutput);
		}

		//スクリプト(単体)
		private void button6_Click(object sender, EventArgs e)
		{
			if (listBox2.SelectedItem == null)
			{
				MessageBox.Show("有効中のスクリプトを選択してください。");
				return;
			}
			string strSelName = listBox2.SelectedItem.ToString();
			string strOutput = "skript reload " + strSelName;
			refForm.fncExecuteCommand(strOutput);
		}

	}
}
