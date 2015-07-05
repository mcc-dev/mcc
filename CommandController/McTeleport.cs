using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class McTeleport : UserControl
	{
		private AppMainForm refForm;
		//private AutoCompleteStringCollection autoCompList;

		public McTeleport()
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
			//autoCompList = new AutoCompleteStringCollection();
			textBox1.AutoCompleteCustomSource = refForm.autoCompList;
			textBox2.AutoCompleteCustomSource = refForm.autoCompList;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.TextLength == 0) {
				MessageBox.Show("テレポート対象が指定されていません。");
				return;
			}
			if (textBox2.TextLength == 0)
			{
				MessageBox.Show("テレポート先が指定されていません。");
				return;
			}
			string newItem;
			newItem = textBox1.Text.Trim();
			refForm.fncAddUser(newItem);
			newItem = textBox2.Text.Trim();
			refForm.fncAddUser(newItem);

			string strOutput = "";
			string fromPlayer = textBox1.Text;
			string toPlayer = textBox2.Text;
			strOutput += "tp " + fromPlayer + " " + toPlayer;
			refForm.fncExecuteCommand(strOutput);
		}

		private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (textBox1.TextLength == 0)
			{
				MessageBox.Show("テレポート対象が指定されていません。");
				return;
			}
			if (dataGridView1.Rows[e.RowIndex].Cells[1].Value == null)
			{
				MessageBox.Show("X座標が指定されていません。");
				return;
			}
			if (dataGridView1.Rows[e.RowIndex].Cells[2].Value == null)
			{
				MessageBox.Show("Y座標が指定されていません。");
				return;
			}
			if (dataGridView1.Rows[e.RowIndex].Cells[3].Value == null)
			{
				MessageBox.Show("Z座標が指定されていません。");
				return;
			}
			string fromPlayer = textBox1.Text;
			string xPos = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			string yPos = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			string zPos = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			string strOutput = "";
			strOutput += "tp " + fromPlayer + " " + xPos + " " + yPos + " " + zPos;
			refForm.fncExecuteCommand(strOutput);
		}
	}
}
