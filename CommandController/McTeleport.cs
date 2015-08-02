using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class McTeleport : UserControl
	{
		private AppMainForm refForm;

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
			textBox1.Text = refForm.appSettings.MyID;
			textBox1.AutoCompleteCustomSource = refForm.autoCompList;
			textBox2.AutoCompleteCustomSource = refForm.autoCompList;
			foreach (AppData.Teleport.BookMark bm in refForm.appData.teleport.BookMarkList) {
				//グリッドに追加
				dataGridView1.Rows.Add();
				int idx = dataGridView1.Rows.Count - 1;
				dataGridView1.Rows[idx].Cells[0].Value = bm.name;
				dataGridView1.Rows[idx].Cells[1].Value = bm.xPos;
				dataGridView1.Rows[idx].Cells[2].Value = bm.yPos;
				dataGridView1.Rows[idx].Cells[3].Value = bm.zPos;
				dataGridView1.Rows[idx].Cells[4].Value = bm.remark;
			}
		}

		private bool fncConfirm(string message)
		{
			//メッセージボックスを表示する
			DialogResult result = MessageBox.Show(
				message,
				"確認",
				MessageBoxButtons.YesNo);

			//何が選択されたか調べる
			if (result == DialogResult.Yes)
			{
				//「はい」が選択された時
				return true;
			}
			else
			{
				//「いいえ」が選択された時
				return false;
			}
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

		private void button1_Click(object sender, EventArgs e)
		{
			McPositionForm form = new McPositionForm(this);
			form.ShowDialog(); 
		}

		public void fncAddPosition(string name, int xPos, int yPos, int zPos, string remark)
		{
			//グリッドに追加
			dataGridView1.Rows.Add();
			int idx = dataGridView1.Rows.Count - 1;
			dataGridView1.Rows[idx].Cells[0].Value = name;
			dataGridView1.Rows[idx].Cells[1].Value = xPos;
			dataGridView1.Rows[idx].Cells[2].Value = yPos;
			dataGridView1.Rows[idx].Cells[3].Value = zPos;
			dataGridView1.Rows[idx].Cells[4].Value = remark;

			//保存用データにも追加(本来はAppDataに口を用意すべき)
			AppData.Teleport.BookMark bm = new AppData.Teleport.BookMark();
			bm.name = name;
			bm.xPos = xPos;
			bm.yPos = yPos;
			bm.zPos = zPos;
			bm.remark = remark;
			refForm.appData.teleport.BookMarkList.Add(bm);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (dgv.Columns[e.ColumnIndex].Name == "Column6")
			{
				//実行
				if (textBox1.TextLength == 0)
				{
					MessageBox.Show("テレポート対象が指定されていません。");
					return;
				}
				if (!fncConfirm("テレポートします。よろしいですか？"))
				{
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
			else if (dgv.Columns[e.ColumnIndex].Name == "Column7")
			{
				//削除
				if (!fncConfirm("削除します。よろしいですか？"))
				{
					return;
				}
				dgv.Rows.RemoveAt(e.RowIndex);
				refForm.appData.teleport.BookMarkList.RemoveAt(e.RowIndex);
			}
		}

		private void dataGridView1_Leave(object sender, EventArgs e)
		{
			dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = false;
		}
	}
}
