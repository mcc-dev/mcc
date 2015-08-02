using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommandController
{
	public partial class HeCommand : UserControl
	{
		private AppMainForm refForm;

		public HeCommand()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
			fncInit();
		}

		private void fncInit()
		{
			textBox2.AutoCompleteCustomSource = refForm.autoCompList;
			dateTimePicker1.CustomFormat = "yyyy-MM-dd,HH:mm:ss";
			dateTimePicker2.CustomFormat = "yyyy-MM-dd,HH:mm:ss";

			comboBox1.Items.Add("");
			comboBox1.Items.Add("lava-bucket");
			comboBox1.Items.Add("water-bucket");
			comboBox1.Items.Add("item-place");
			comboBox1.Items.Add("pvp-death");
			comboBox1.Items.Add("mob-deat");
			comboBox1.Items.Add("other-death");
			comboBox1.Items.Add("command");
			comboBox1.Items.Add("chat");
			comboBox1.Items.Add("join");
			comboBox1.Items.Add("quit");
			comboBox1.Items.Add("door-interact");
			comboBox1.Items.Add("open-container");
			comboBox1.Items.Add("container-transaction");
			comboBox1.Items.Add("item-pickup");
			comboBox1.Items.Add("item-drop");
			comboBox1.Items.Add("button");
			comboBox1.Items.Add("teleport");
			comboBox1.Items.Add("lever");
			comboBox1.Items.Add("sign-place");
			comboBox1.Items.Add("sign-break");
			comboBox1.Items.Add("item-break");
			comboBox1.Items.Add("flint-steel");
			comboBox1.Items.Add("block-place");
			comboBox1.Items.Add("block-break");
			comboBox1.Items.Add("block-burn");
			comboBox1.Items.Add("block-fade");
			comboBox1.Items.Add("block-form");
			comboBox1.Items.Add("leaf-decay");
			comboBox1.Items.Add("mushroom-grow");
			comboBox1.Items.Add("tree-grow");
			comboBox1.Items.Add("water-flow");
			comboBox1.Items.Add("lava-flow");
			comboBox1.Items.Add("explosion");
			comboBox1.Items.Add("enderman-pickup");
			comboBox1.Items.Add("enderman-place");
			comboBox1.Items.Add("entity-kill");
			comboBox1.Items.Add("other");
			comboBox1.Items.Add("spawnmob-egg");
			comboBox1.Items.Add("herochat");
			comboBox1.Items.Add("entity-modify");
			comboBox1.Items.Add("block-inhabit");
			comboBox1.Items.Add("super-pickaxe");
			comboBox1.Items.Add("worldedit-place");
			comboBox1.Items.Add("worldedit-break");
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

		//ページング実行
		private void fncHePage(int page)
		{
			//マウスポインタの位置を取得する
			//X座標を取得する
			int x = Cursor.Position.X;
			//Y座標を取得する
			int y = Cursor.Position.Y;

			if (page <= 0)
			{
				page = 1;
			}
			textBox1.Text = page.ToString();
			string strOutput = "";
			strOutput += "he page " + page;
			refForm.fncExecuteCommand(strOutput);
			Win32API.keybd_click(Win32API.VK_DIVIDE);

			//マウスポインタの位置を元に戻す
			Cursor.Position = new Point(x, y);
		}

		//ページ文字列を数値に変換、変換できないならデフォルト1
		private int fncPageFormat(string p)
		{
			int page = 1;
			int.TryParse(p, out page);
			return page;
		}

		//パラメータ生成
		private string fncSetParameters()
		{
			string player = textBox2.Text;
			//string action = textBox3.Text;
			string action = comboBox1.Text;
			string keyword = textBox4.Text;
			string world = textBox5.Text;
			string posX = textBox6.Text;
			string posY = textBox7.Text;
			string posZ = textBox8.Text;
			string radius = textBox9.Text;
			string termStart = dateTimePicker1.Text;
			string termEnd = dateTimePicker2.Text;

			string parameters = "";
			parameters += (string.IsNullOrEmpty(player)) ? "" : " p:" + player;
			parameters += (string.IsNullOrEmpty(action)) ? "" : " a:" + action;
			parameters += (string.IsNullOrEmpty(keyword)) ? "" : " f:" + keyword;
			parameters += (string.IsNullOrEmpty(world)) ? "" : " w:" + world;
			parameters +=
				(string.IsNullOrEmpty(posX) || string.IsNullOrEmpty(posX) || string.IsNullOrEmpty(posX))
				? ""
				: " l:" + posX + "," + posY + "," + posZ;
			parameters += (string.IsNullOrEmpty(radius)) ? "" : " r:" + radius;
			if (checkBox7.Checked)
			{
				parameters += " t:" + termStart + "," + termEnd;
			}

			if (parameters.Length == 0)
			{
				MessageBox.Show("パラメーターを設定してください。");
				return parameters;
			}

			ListBoxCustomItem lbci1 = new ListBoxCustomItem();
			lbci1.Text = parameters;
			lbci1.Player = player;
			lbci1.Action = action;
			lbci1.Keyword = keyword;
			lbci1.World = world;
			lbci1.PosX = posX;
			lbci1.PosY = posY;
			lbci1.PosZ = posZ;
			lbci1.Radius = radius;
			if (checkBox7.Checked)
			{
				lbci1.TermStart = termStart;
				lbci1.TermEnd = termEnd;
			}
			fncAddHistory(lbci1);

			return parameters;
		}

		private void fncAddHistory(ListBoxCustomItem lbci)
		{
			int i = 0;
			int length = listBox1.Items.Count;
			ListBoxCustomItem tmpLbci;

			for (i = 0; i < length; i++)
			{
				tmpLbci = (ListBoxCustomItem)listBox1.Items[i];
				if (tmpLbci.Equals(lbci))
				{
					listBox1.Items.RemoveAt(i);
					break;
				}
			}

			listBox1.Items.Insert(0, lbci);
		}

		private void textBox1_KeyDown(object sender, KeyEventArgs e)
		{
			//押されたキーがエンターキーかどうかの条件分岐
			if (e.KeyCode == Keys.Enter)
			{
				int page = fncPageFormat(textBox1.Text);
				fncHePage(page);
			}
		}

		// エンターキーを押した際の音を消すためにキーイベントが処理されたことにする
		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				e.Handled = true;
			}
		}

		//ページング
		private void button1_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page -= 100;
			fncHePage(page);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page -= 10;
			fncHePage(page);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page -= 5;
			fncHePage(page);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page -= 1;
			fncHePage(page);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page += 1;
			fncHePage(page);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page += 5;
			fncHePage(page);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page += 10;
			fncHePage(page);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			int page = fncPageFormat(textBox1.Text);
			page += 100;
			fncHePage(page);
		}

		//検索
		private void button9_Click(object sender, EventArgs e)
		{
			string strOutput = "";
			string parameters = fncSetParameters();
			if (parameters.Length == 0)
			{
				return;
			}
			textBox1.Text = "1";
			strOutput += "he search" + parameters;
			refForm.fncExecuteCommand(strOutput);
			Win32API.keybd_click(Win32API.VK_DIVIDE);
		}

		//プレビュー
		private void button10_Click(object sender, EventArgs e)
		{
			string strOutput = "";
			string parameters = fncSetParameters();
			if (parameters.Length == 0)
			{
				return;
			}
			strOutput += "he preview" + parameters;
			refForm.fncExecuteCommand(strOutput);
		}

		//適用
		private void button11_Click(object sender, EventArgs e)
		{
			string message = "プレビューを適用させます。よろしいですか？";
			//確認後実行
			if (fncConfirm(message))
			{
				string strOutput = "";
				strOutput += "he preview apply";
				refForm.fncExecuteCommand(strOutput);
			}
		}

		//キャンセル
		private void button12_Click(object sender, EventArgs e)
		{
			string strOutput = "";
			strOutput += "he preview cancel";
			refForm.fncExecuteCommand(strOutput);
		}

		//ロールバック
		private void button13_Click(object sender, EventArgs e)
		{
			string message = "ロールバックを実行します。よろしいですか？";
			//確認後実行
			if (fncConfirm(message))
			{
				string strOutput = "";
				string parameters = fncSetParameters();
				if (parameters.Length == 0)
				{
					return;
				}
				strOutput += "he rollback" + parameters;
				refForm.fncExecuteCommand(strOutput);
			}
		}

		//元に戻す
		private void button14_Click(object sender, EventArgs e)
		{
			string message = "ロールバック前に戻します。よろしいですか？";
			//確認後実行
			if (fncConfirm(message))
			{
				string strOutput = "";
				strOutput += "he undo";
				refForm.fncExecuteCommand(strOutput);
			}
		}

		//やり直し
		private void button15_Click(object sender, EventArgs e)
		{
			string message = "undoで戻す前の状態に戻します。よろしいですか？";
			//確認後実行
			if (fncConfirm(message))
			{
				string strOutput = "";
				strOutput += "he rebuild";
				refForm.fncExecuteCommand(strOutput);
			}
		}

		//履歴入力
		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			// 選択されている行のデータを取り込む
			ListBoxCustomItem selItem = (ListBoxCustomItem)listBox1.SelectedItem;
			if (selItem == null)
			{
				return;
			}

			textBox2.Text = selItem.Player;
			//textBox3.Text = selItem.Action;
			comboBox1.Text = selItem.Action;
			textBox4.Text = selItem.Keyword;
			textBox5.Text = selItem.World;
			textBox6.Text = selItem.PosX;
			textBox7.Text = selItem.PosY;
			textBox8.Text = selItem.PosZ;
			textBox9.Text = selItem.Radius;
			if (selItem.TermStart == "" && selItem.TermEnd == "")
			{
				checkBox7.Checked = false;
			}
			else
			{
				checkBox7.Checked = true;
				dateTimePicker1.Text = selItem.TermStart;
				dateTimePicker2.Text = selItem.TermEnd;
			}

		}

		//現在日時セット
		private void button16_Click(object sender, EventArgs e)
		{
			dateTimePicker2.Value = DateTime.Now;
		}

		//検索条件クリア
		private void button17_Click(object sender, EventArgs e)
		{
			textBox2.Text = "";
			comboBox1.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
			checkBox7.Checked = false;
		}

	}

	public class ListBoxCustomItem
	{
		public string Text { get; set; }
		public string Player { get; set; }
		public string Action { get; set; }
		public string Keyword { get; set; }
		public string World { get; set; }
		public string PosX { get; set; }
		public string PosY { get; set; }
		public string PosZ { get; set; }
		public string Radius { get; set; }
		public string TermStart { get; set; }
		public string TermEnd { get; set; }

		public ListBoxCustomItem()
		{
			Text = "";
			Player = "";
			Action = "";
			Keyword = "";
			World = "";
			PosX = "";
			PosY = "";
			PosZ = "";
			Radius = "";
			TermStart = "";
			TermEnd = "";
		}

		public override string ToString()
		{
			return Text;
		}

		//objと自分自身が等価のときはtrueを返す
		public override bool Equals(object obj)
		{
			//objがnullか、型が違うときは、等価でない
			if (obj == null || this.GetType() != obj.GetType())
			{
				return false;
			}
			ListBoxCustomItem lbci = (ListBoxCustomItem)obj;
			if (this.Text != lbci.Text) { return false; }
			if (this.Player != lbci.Player) { return false; }
			if (this.Action != lbci.Action) { return false; }
			if (this.Keyword != lbci.Keyword) { return false; }
			if (this.World != lbci.World) { return false; }
			if (this.PosX != lbci.PosX) { return false; }
			if (this.PosY != lbci.PosY) { return false; }
			if (this.PosZ != lbci.PosZ) { return false; }
			if (this.Radius != lbci.Radius) { return false; }
			if (this.TermStart != lbci.TermStart) { return false; }
			if (this.TermEnd != lbci.TermEnd) { return false; }
			return true;
		}

		//Equalsがtrueを返すときに同じ値を返す
		public override int GetHashCode()
		{
			return this.Text.GetHashCode();
		}
	}

}
