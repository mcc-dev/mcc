using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class McEffect : UserControl
	{
		private AppMainForm refForm;

		public McEffect()
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
			textBox1.Text = refForm.appSettings.MyID;
			textBox1.AutoCompleteCustomSource = refForm.autoCompList;
		}

		private void McEffect_Load(object sender, EventArgs e)
		{
			ComboBoxCustomItem cbci1 = new ComboBoxCustomItem();
			cbci1.id = 1;
			cbci1.name = "移動速度上昇";
			cbci1.code = "SPEED"; //SPEED

			ComboBoxCustomItem cbci2 = new ComboBoxCustomItem();
			cbci2.id = 2;
			cbci2.name = "移動速度低下";
			cbci2.code = "SLOW"; //SLOW

			ComboBoxCustomItem cbci3 = new ComboBoxCustomItem();
			cbci3.id = 3;
			cbci3.name = "採掘速度上昇";
			cbci3.code = "FAST_DIGGING"; //FAST_DIGGING

			ComboBoxCustomItem cbci4 = new ComboBoxCustomItem();
			cbci4.id = 4;
			cbci4.name = "採掘速度低下";
			cbci4.code = "SLOW_DIGGING"; //SLOW_DIGGING

			ComboBoxCustomItem cbci5 = new ComboBoxCustomItem();
			cbci5.id = 5;
			cbci5.name = "攻撃力上昇";
			cbci5.code = "INCREASE_DAMAGE"; //INCREASE_DAMAGE

			ComboBoxCustomItem cbci6 = new ComboBoxCustomItem();
			cbci6.id = 6;
			cbci6.name = "即時回復";
			cbci6.code = "HEAL"; //HEAL

			ComboBoxCustomItem cbci7 = new ComboBoxCustomItem();
			cbci7.id = 7;
			cbci7.name = "ダメージ";
			cbci7.code = "HARM"; //HARM

			ComboBoxCustomItem cbci8 = new ComboBoxCustomItem();
			cbci8.id = 8;
			cbci8.name = "跳躍力上昇";
			cbci8.code = "JUMP"; //JUMP

			ComboBoxCustomItem cbci9 = new ComboBoxCustomItem();
			cbci9.id = 9;
			cbci9.name = "吐き気";
			cbci9.code = "CONFUSION"; //CONFUSION

			ComboBoxCustomItem cbci10 = new ComboBoxCustomItem();
			cbci10.id = 10;
			cbci10.name = "再生能力";
			cbci10.code = "REGENERATION"; //REGENERATION

			ComboBoxCustomItem cbci11 = new ComboBoxCustomItem();
			cbci11.id = 11;
			cbci11.name = "耐性";
			cbci11.code = "DAMAGE_RESISTANCE"; //DAMAGE_RESISTANCE

			ComboBoxCustomItem cbci12 = new ComboBoxCustomItem();
			cbci12.id = 12;
			cbci12.name = "火炎耐性";
			cbci12.code = "FIRE_RESISTANCE"; //FIRE_RESISTANCE

			ComboBoxCustomItem cbci13 = new ComboBoxCustomItem();
			cbci13.id = 13;
			cbci13.name = "水中呼吸";
			cbci13.code = "WATER_BREATHING"; //WATER_BREATHING

			ComboBoxCustomItem cbci14 = new ComboBoxCustomItem();
			cbci14.id = 14;
			cbci14.name = "透明化";
			cbci14.code = "INVISIBILITY"; //INVISIBILITY

			ComboBoxCustomItem cbci15 = new ComboBoxCustomItem();
			cbci15.id = 15;
			cbci15.name = "盲目";
			cbci15.code = "BLINDNESS"; //BLINDNESS

			ComboBoxCustomItem cbci16 = new ComboBoxCustomItem();
			cbci16.id = 16;
			cbci16.name = "暗視";
			cbci16.code = "NIGHT_VISION"; //NIGHT_VISION

			ComboBoxCustomItem cbci17 = new ComboBoxCustomItem();
			cbci17.id = 17;
			cbci17.name = "空腹";
			cbci17.code = "HUNGER"; //HUNGER

			ComboBoxCustomItem cbci18 = new ComboBoxCustomItem();
			cbci18.id = 18;
			cbci18.name = "弱体化";
			cbci18.code = "WEAKNESS"; //WEAKNESS

			ComboBoxCustomItem cbci19 = new ComboBoxCustomItem();
			cbci19.id = 19;
			cbci19.name = "毒";
			cbci19.code = "POISON"; //POISON

			ComboBoxCustomItem cbci20 = new ComboBoxCustomItem();
			cbci20.id = 20;
			cbci20.name = "ウィザー";
			cbci20.code = "WITHER"; //WITHER

			ComboBoxCustomItem cbci21 = new ComboBoxCustomItem();
			cbci21.id = 21;
			cbci21.name = "体力増強";
			cbci21.code = "HEALTH_BOOST"; //HEALTH_BOOST

			ComboBoxCustomItem cbci22 = new ComboBoxCustomItem();
			cbci22.id = 22;
			cbci22.name = "衝撃吸収";
			cbci22.code = "ABSORPTION"; //ABSORPTION

			comboBox1.Items.Add(cbci1);
			comboBox1.Items.Add(cbci2);
			comboBox1.Items.Add(cbci3);
			comboBox1.Items.Add(cbci4);
			comboBox1.Items.Add(cbci5);
			comboBox1.Items.Add(cbci6);
			comboBox1.Items.Add(cbci7);
			comboBox1.Items.Add(cbci8);
			comboBox1.Items.Add(cbci9);
			comboBox1.Items.Add(cbci10);
			comboBox1.Items.Add(cbci11);
			comboBox1.Items.Add(cbci12);
			comboBox1.Items.Add(cbci13);
			comboBox1.Items.Add(cbci14);
			comboBox1.Items.Add(cbci15);
			comboBox1.Items.Add(cbci16);
			comboBox1.Items.Add(cbci17);
			comboBox1.Items.Add(cbci18);
			comboBox1.Items.Add(cbci19);
			comboBox1.Items.Add(cbci20);
			comboBox1.Items.Add(cbci21);
			comboBox1.Items.Add(cbci22);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ComboBoxCustomItem selItem = (ComboBoxCustomItem)comboBox1.SelectedItem;
			if (selItem == null)
			{
				MessageBox.Show("効果を指定してください。");
				return;
			}
			string player = textBox1.Text.Trim();
			string effect = selItem.id.ToString();
			string seconds = textBox2.Text.Trim();
			string amplifier = textBox3.Text.Trim();
			//string hideParticle = "false";
			string hideParticle = "";
			if (radioButton2.Checked)
			{
				hideParticle = "true";
			}
			refForm.fncAddUser(player);

			String strOutput = "";
			strOutput += 
				"effect" + 
				" " + player + 
				" " + effect + 
				" " + seconds + 
				" " + amplifier + 
				" " + hideParticle;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string player = textBox1.Text.Trim();
			String strOutput = "";
			strOutput +=
				"effect" + 
				" " + player + 
				" " + "clear";
			refForm.fncExecuteCommand(strOutput);
		}

	}

	public class ComboBoxCustomItem
	{
		public int id;
		public string name;
		public string code;

		public override string ToString()
		{
			return name;
		}
	}
}
