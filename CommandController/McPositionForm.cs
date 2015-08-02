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
	public partial class McPositionForm : Form
	{
		McTeleport pForm;

		public McPositionForm(McTeleport f)
		{
			pForm = f;
			InitializeComponent();
		}

		//追加ボタン
		private void button1_Click(object sender, EventArgs e)
		{
			string name = textBox1.Text;
			int xPos;
			int yPos;
			int zPos;
			string remark = textBox5.Text;
			if (string.IsNullOrEmpty(name))
			{
				MessageBox.Show("名称を入力してください。");
				return;
			}
			if (!int.TryParse(textBox2.Text, out xPos) || !int.TryParse(textBox3.Text, out yPos) || !int.TryParse(textBox4.Text, out zPos))
			{
				MessageBox.Show("座標は整数で指定してください。");
				return;
			}
			if (remark == null)
			{
				remark = "";
			}
			pForm.fncAddPosition(name, xPos, yPos, zPos, remark);
			this.Close();
		}

		//キャンセルボタン
		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
