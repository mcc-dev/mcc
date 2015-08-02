using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class SkShiensaba : UserControl
	{
		private AppMainForm refForm;

		public SkShiensaba()
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

		private void button1_Click(object sender, EventArgs e)
		{
			string strOutput = "hide";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string strOutput = "show 0";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			string strOutput = "show 1";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string strOutput = "gmchange 0";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			string strOutput = "gmchange 1";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			string strOutput = "gmchange 2";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			string target = textBox1.Text.Trim();
			string strOutput = "";
			strOutput += "enderchest";
			if (target.Length > 0)
			{
				strOutput += " " + target;
			}
			refForm.fncExecuteCommand(strOutput);
		}
	}
}
