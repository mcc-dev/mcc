using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class McEnchant : UserControl
	{
		private AppMainForm refForm;

		public McEnchant()
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
			textBox100.Text = refForm.appSettings.MyID;
			textBox100.AutoCompleteCustomSource = refForm.autoCompList;
		}
		private void fncDoEnchant(TableLayoutPanel table, object sender, String enchant)
		{
			if (textBox100.Text == "") {
				MessageBox.Show("対象IDを指定してください。");
				return;
			}
			Button btn = (Button)sender;
			TableLayoutPanelCellPosition pos = table.GetCellPosition(btn);
			pos.Column -= 1;
			Control c = table.GetControlFromPosition(pos.Column, pos.Row);
			String player = textBox100.Text;
			refForm.fncAddUser(player);


			String strOutput = "";
			strOutput += "enchant " + player + " " + enchant + " " + c.Text + " force";
			refForm.fncExecuteCommand(strOutput);
		}

		//防具
		private void button1_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "0"); //PROTECTION_ENVIRONMENTAL
		}

		private void button2_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "1"); //PROTECTION_FIRE
		}

		private void button3_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "4"); //PROTECTION_PROJECTILE
		}

		private void button4_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "3"); //PROTECTION_EXPLOSIONS
		}

		private void button5_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "7"); //THORNS
		}

		private void button6_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "2"); //PROTECTION_FALL
		}

		private void button7_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "5"); //OXYGEN
		}

		private void button8_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel1, sender, "6"); //WATER_WORKER
		}

		//武器
		private void button9_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel2, sender, "16"); //DAMAGE_ALL
		}

		private void button10_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel2, sender, "17"); //DAMAGE_UNDEAD
		}

		private void button11_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel2, sender, "18"); //DAMAGE_ARTHROPODS
		}

		private void button12_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel2, sender, "19"); //KNOCKBACK
		}

		private void button13_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel2, sender, "20"); //FIRE_ASPECT
		}

		private void button14_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel2, sender, "21"); //LOOT_BONUS_MOBS
		}

		//釣り竿
		private void button15_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel5, sender, "61"); //LUCK
		}

		private void button16_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel5, sender, "62"); //LURE
		}

		//ツール
		private void button18_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel4, sender, "32"); //DIG_SPEED
		}

		private void button19_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel4, sender, "34"); //DURABILITY
		}

		private void button20_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel4, sender, "35"); //LOOT_BONUS_BLOCKS
		}

		private void button21_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel4, sender, "33"); //SILK_TOUCH
		}

		//弓
		private void button22_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel3, sender, "48"); //ARROW_DAMAGE
		}

		private void button23_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel3, sender, "49"); //ARROW_KNOCKBACK
		}

		private void button24_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel3, sender, "50"); //ARROW_FIRE
		}

		private void button25_Click(object sender, EventArgs e)
		{
			fncDoEnchant(tableLayoutPanel3, sender, "51"); //ARROW_INFINITE
		}
	}
}
