using System;
using System.Collections.Generic;
using System.Windows.Forms;

using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;

namespace MinecraftCommandController.Util
{
	public partial class PlayerSelectForm : Form
	{
		PlayerSelect playerSelect;

		public PlayerSelectForm(PlayerSelect ps)
		{
			InitializeComponent();
			playerSelect = ps;
			init();
		}

		private void init()
		{
			PlayerCollectionEt pc = new PlayerCollectionEt();
			PlayerDao dao = new PlayerDao();
			pc = dao.LoadXml(@".\Data\players.xml");
			if (pc != null)
			{
				foreach (PlayerEt player in pc.list)
				{
					listBox1.Items.Add(player.Name);
				}
			}
		}

		public PlayerSelectForm()
		{
			InitializeComponent();
			init();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null)
			{
				MessageBox.Show("プレイヤーが未選択です。");
				return;
			}
			playerSelect.fncSetPlayerName(listBox1.SelectedItem.ToString());

			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void PlayerSelectForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			PlayerCollectionEt pc = new PlayerCollectionEt();
			pc.list = new List<PlayerEt>();
			foreach (string item in listBox1.Items)
			{
				PlayerEt player = new PlayerEt();
				player.Name = item;
				pc.list.Add(player);
			}
			PlayerDao dao = new PlayerDao();
			dao.SaveXml(pc, @".\Data\players.xml");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			string input = textBox2.Text;
			if (input == "")
			{
				MessageBox.Show("プレイヤー名を入力してください。");
				return;
			}
			listBox1.Items.Add(input);
			textBox2.Text = "";
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedItem == null)
			{
				MessageBox.Show("プレイヤーが未選択です。");
				return;
			}
			listBox1.Items.Remove(listBox1.SelectedItem);
		}
	}
}
