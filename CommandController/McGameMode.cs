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
			textBox2.Text = refForm.appSettings.MyID;
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

		private bool fncTargetIsEmpty2()
		{
			if (textBox2.Text == "")
			{
				MessageBox.Show("対象IDを指定してください。");
				return true;
			}
			else
			{
				return false;
			}
		}

		//ゲームモード
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

		//難易度
		private void button5_Click(object sender, EventArgs e)
		{
			string strOutput = "";
			strOutput += "difficulty p";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string strOutput = "";
			strOutput += "difficulty e";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string strOutput = "";
			strOutput += "difficulty n";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			string strOutput = "";
			strOutput += "difficulty h";
			refForm.fncExecuteCommand(strOutput);
		}

		//コマンドブロック
		private void button9_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty2())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "give " + target + " minecraft:command_block";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty2())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "give " + target + " minecraft:command_block_minecart";
			refForm.fncExecuteCommand(strOutput);
		}
	}
}
