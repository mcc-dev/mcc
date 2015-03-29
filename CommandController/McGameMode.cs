using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class McGameMode : UserControl
	{
		private AppMainForm refForm;

		public McGameMode()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
			init();
		}

		private void init()
		{
			textBox1.Text = refForm.appSettings.MyID;
			textBox1.AutoCompleteCustomSource = refForm.autoCompList;
		}

		private bool fncTargetIsEmpty()
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("対象IDを指定してください。");
				return true;
			}
			else
			{
				return false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox1.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "gamemode 0 " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox1.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "gamemode 1 " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox1.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "gamemode 2 " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox1.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "gamemode 3 " + target;
			refForm.fncExecuteCommand(strOutput);
		}
	}
}
