using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;
using MinecraftCommandController.Util;

namespace MinecraftCommandController
{
	public partial class ClientSettingForm : Form
	{
		private AppMainForm appMainForm;

		private void init()
		{
			SettingEt settings = SettingDao.ReferSettings();
			if (settings.ExcuteType == 1)
			{
				radioButton1.Checked = true;
			}
			else if (settings.ExcuteType == 4)
			{
				radioButton2.Checked = true;
			}
			else
			{
				radioButton1.Checked = true;
			}
		}

		public ClientSettingForm(AppMainForm form)
		{
			InitializeComponent();
			appMainForm = form;
			init();
		}

		// 実行タイプの入力情報取得
		private int fncGetInputExcuteType()
		{
			int type = 0;
			if (radioButton1.Checked)
			{
				type = 1;
			}
			else if (radioButton2.Checked)
			{
				type = 4;
			}
			return type;
		}

		// 該当プロセスの取得
		private void fncGetProcessList()
		{
			List<Process> lProcess = new List<Process>();
			lProcess = TargetWindow.fncFindTargetAll(fncGetInputExcuteType());
			foreach (Process p in lProcess)
			{
				ListBoxProcessItem item = new ListBoxProcessItem();
				item.Text = p.Id.ToString();
				item.Process = p;
				listBox1.Items.Add(item);
			}
		}

		// プロセス用リストボックスアイテム
		public class ListBoxProcessItem
		{
			public string Text { get; set; }
			public Process Process { get; set; }

			public ListBoxProcessItem()
			{
				Text = "";
				Process = null;
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
				ListBoxProcessItem item = (ListBoxProcessItem)obj;
				if (this.Text != item.Text) { return false; }
				if (this.Process != item.Process) { return false; }
				return true;
			}

			//Equalsがtrueを返すときに同じ値を返す
			public override int GetHashCode()
			{
				return this.Text.GetHashCode();
			}
		}


		//デザイナーからの半自動生成
		public ClientSettingForm() //未使用
		{
			InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				listBox1.Enabled = true;
				button1.Enabled = true;
				button2.Enabled = true;
				fncGetProcessList();
			}
			else
			{
				listBox1.Items.Clear();
				listBox1.Enabled = false;
				button1.Enabled = false;
				button2.Enabled = false;
			}
		}

		// OKボタン
		private void button3_Click(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				// 選択されている行のデータ
				ListBoxProcessItem selItem = (ListBoxProcessItem)listBox1.SelectedItem;
				if (selItem == null)
				{
					MessageBox.Show("プロセスを選択してください。");
					return;
				}
				AppSession.isSelectedProcess = true;
				AppSession.TargetProcess = selItem.Process;
			}
			else
			{
				AppSession.isSelectedProcess = false;
				AppSession.TargetProcess = null;
			}

			SettingEt settings = SettingDao.ReferSettings();
			settings.ExcuteType = fncGetInputExcuteType();
			SettingDao.SaveSettings();
			this.Close();
		}

		// キャンセルボタン
		private void button4_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton1.Checked)
			{
				if (checkBox1.Checked)
				{
					listBox1.Items.Clear();
					fncGetProcessList();
				}
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton2.Checked)
			{
				if (checkBox1.Checked)
				{
					listBox1.Items.Clear();
					fncGetProcessList();
				}
			}
		}

		// 再検索
		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			fncGetProcessList();
		}
		// アクティブ確認
		private void button2_Click(object sender, EventArgs e)
		{
			// 選択されている行のデータ
			ListBoxProcessItem selItem = (ListBoxProcessItem)listBox1.SelectedItem;
			if (selItem == null)
			{
				MessageBox.Show("プロセスを選択してください。");
				return;
			}
			TargetWindow.fncActiveTarget(selItem.Process);

		}
	}
}
