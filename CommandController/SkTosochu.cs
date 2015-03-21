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
	public partial class SkTosochu : UserControl
	{
		private AppMainForm refForm;

		public SkTosochu()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
		}

		private void button25_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_preset";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button26_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "start";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button27_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_run_pose";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button28_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_run_resume";
			refForm.fncExecuteCommand(strOutput);
		}

		private void button30_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_run_stop";
			refForm.fncExecuteCommand(strOutput);
		}

		//プニキ
		private void button31_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://games.kids.yahoo.co.jp/sports/013.html");
		}

		//開始時間設定
		private void button29_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_time_set " + textBox13.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント1
		private void button1_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E1 " + textBox1.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button13_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E1 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント2
		private void button2_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E2 " + textBox2.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button14_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E2 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント3
		private void button3_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E3 " + textBox3.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button15_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E3 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント4
		private void button4_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E4 " + textBox4.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button16_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E4 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント5
		private void button5_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E5 " + textBox5.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button17_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E5 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント6
		private void button6_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E6 " + textBox6.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button18_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E6 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント7
		private void button7_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E7 " + textBox7.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button19_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E7 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント8
		private void button8_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E8 " + textBox8.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button20_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E8 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント9
		private void button9_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E9 " + textBox9.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button21_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E9 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント10
		private void button10_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E10 " + textBox10.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button22_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E10 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント11
		private void button11_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E11 " + textBox11.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button23_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E11 0";
			refForm.fncExecuteCommand(strOutput);
		}

		//イベント12
		private void button12_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_event_set E12 " + textBox12.Text;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button24_Click(object sender, EventArgs e)
		{
			String strOutput = "";
			strOutput += "tsc_limit_set E12 0";
			refForm.fncExecuteCommand(strOutput);
		}
	}
}
