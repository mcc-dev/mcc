using System.Windows.Forms;

using MinecraftCommandController.Base;
using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;

namespace MinecraftCommandController.Contents.Minecraft
{
	public partial class McGameRule : MccContentPageBase
	{
		private AppMainForm appMainForm; //メインフォームの参照

		// コンストラクタ
		public McGameRule(AppMainForm form)
		{
			this.appMainForm = form;
			InitializeComponent();
			init();
		}

		// 初期処理
		private void init()
		{
			// エフェクトデータ読込
			GameRuleCollectionEt grc = new GameRuleCollectionEt();
			GameRuleDao dao = new GameRuleDao();
			grc = dao.LoadXml(@".\Resource\gamerules.xml");
			// アイテムに追加
			if (grc != null)
			{
				foreach (GameRuleEt rule in grc.list)
				{
					ComboBoxGameRuleItem item = new ComboBoxGameRuleItem(rule);
					comboBox1.Items.Add(item);
					dataGridView1.Rows.Add(item.entity.Name, item.entity.Description, item.entity.Default);
				}
			}
		}

		// 効果選択用のコンボボックスアイテム
		public class ComboBoxGameRuleItem
		{
			public GameRuleEt entity;

			public ComboBoxGameRuleItem(GameRuleEt et)
			{
				this.entity = et;
			}

			public override string ToString()
			{
				return entity.Name;
			}
		}

		/* ***** 以下、デザイナからの半自動生成 ***** */
		// 未使用コンストラクタ
		public McGameRule()
		{
			InitializeComponent();
		}

		// 選択ルールによって入力を分ける
		private void comboBox1_SelectedValueChanged(object sender, System.EventArgs e)
		{
			ComboBoxGameRuleItem item = (ComboBoxGameRuleItem)comboBox1.SelectedItem;
			switch (item.entity.Type)
			{
				case 1:
					radioButton1.Enabled = true;
					radioButton2.Enabled = true;
					numericUpDown1.Enabled = false;
					break;
				case 2:
					radioButton1.Enabled = false;
					radioButton2.Enabled = false;
					numericUpDown1.Enabled = true;
					break;
				default:
					radioButton1.Enabled = false;
					radioButton2.Enabled = false;
					numericUpDown1.Enabled = false;
					break;
			}
		}

		// 確認ボタン
		private void button1_Click(object sender, System.EventArgs e)
		{
			// ルール
			ComboBoxGameRuleItem item = (ComboBoxGameRuleItem)comboBox1.SelectedItem;
			if (item == null)
			{
				MessageBox.Show("ルールを選択してください。");
				return;
			}
			string sRule = item.entity.Name.ToString();

			// コマンド実行
			string cmd = "";
			cmd += "gamerule";
			cmd += " " + sRule;
			appMainForm.fncExecuteCommand(cmd);
		}

		// 実行ボタン
		private void button2_Click(object sender, System.EventArgs e)
		{
			// ルール
			ComboBoxGameRuleItem item = (ComboBoxGameRuleItem)comboBox1.SelectedItem;
			if (item == null)
			{
				MessageBox.Show("ルールを選択してください。");
				return;
			}
			string sRule = item.entity.Name.ToString();

			// 設定値
			string sValue = "";
			switch (item.entity.Type)
			{
				case 1:
					// ラジオボタンの値取得
					foreach (Control ctrl in groupBox1.Controls)
					{
						if (ctrl is RadioButton && ((RadioButton)ctrl).Checked)
						{
							sValue = ctrl.Tag.ToString();
						}
					}
					break;
				case 2:
					// 数値取得
					sValue = numericUpDown1.Value.ToString();
					break;
				default:
					MessageBox.Show("設定値が不明です。");
					break;
			}

			// コマンド実行
			string cmd = "";
			cmd += "gamerule";
			cmd += " " + sRule;
			cmd += " " + sValue;
			appMainForm.fncExecuteCommand(cmd);
		}
	}
}
