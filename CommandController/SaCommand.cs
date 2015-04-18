using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandController
{
	public partial class SaCommand : UserControl
	{
		private AppMainForm refForm;

		public SaCommand()
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
			//textBox1.Text = saItemName;
			textBox2.AutoCompleteCustomSource = refForm.autoCompList;
			//textBox3.Text = saAltChatText;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "sd ents list";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "sd log pvp 1";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "sd log pvp 0";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "sd log redstone 1";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "sd log redstone 0";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == "")
			{
				MessageBox.Show("アイテム名を入力してください。");
				return;
			}
			else
			{
				String strOutput = "";
				strOutput += "sd itemname " + textBox1.Text;
				refForm.fncExecuteCommand(strOutput);
			}
		}

		private bool fncTargetIsEmpty()
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

		private void button7_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd getin " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd invcopy " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd stalker " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd tpb " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd freez " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button12_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd unfreez " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd mute " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			if (fncTargetIsEmpty())
			{
				return;
			}
			string target = textBox2.Text.Trim();
			refForm.fncAddUser(target);
			string strOutput = "";
			strOutput += "sd unmute " + target;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button15_Click(object sender, EventArgs e)
		{
			if (textBox3.Text == "")
			{
				MessageBox.Show("入力欄が空白です。");
				return;
			}
			if (fncTargetIsEmpty())
			{
				return;
			}
			String strOutput = "";
			strOutput += "sd chat " + textBox2.Text + " " + textBox3.Text;
			refForm.fncExecuteCommand(strOutput);
		}

	}
}
