using System.Windows.Forms;

using MinecraftCommandController.Base;
using MinecraftCommandController.Daos;
using MinecraftCommandController.Entities;

namespace MinecraftCommandController.Contents.Minecraft
{
	public partial class McEffect : MccContentPageBase
	{
		private AppMainForm appMainForm; // メインフォームの参照

		// コンストラクタ
		public McEffect(AppMainForm form)
		{
			this.appMainForm = form;
			InitializeComponent();
			init();
		}

		// 初期処理
		private void init()
		{
			// エフェクトデータ読込
			EffectCollectionEt ec = new EffectCollectionEt();
			EffectDao dao = new EffectDao();
			ec = dao.LoadXml(@".\Resource\effects.xml");
			// アイテムに追加
			if (ec != null)
			{
				foreach (EffectEt effect in ec.list)
				{
					ComboBoxEffectItem item = new ComboBoxEffectItem(effect);
					comboBox1.Items.Add(item);
				}
			}

		}

		// 効果選択用のコンボボックスアイテム
		public class ComboBoxEffectItem
		{
			public EffectEt entity;

			public ComboBoxEffectItem(EffectEt et)
			{
				this.entity = et;
			}

			public override string ToString()
			{
				return entity.Name;
			}
		}

		/* ***** 以下、デザイナからの半自動生成 ***** */
		//未使用コンストラクタ
		public McEffect()
		{
			InitializeComponent();
		}

		// 付与
		private void button1_Click(object sender, System.EventArgs e)
		{
			// 対象ID
			if (playerSelect1.fncPlayerIsEmpty())
			{
				MessageBox.Show("対象IDを指定してください。");
				return;
			}
			string sPlayer = playerSelect1.fncGetPlayerName();

			// 効果
			ComboBoxEffectItem item = (ComboBoxEffectItem)comboBox1.SelectedItem;
			if (item == null)
			{
				MessageBox.Show("効果を指定してください。");
				return;
			}
			string sEffect = item.entity.ID.ToString();

			// 秒数
			string sTime = numericUpDown1.Value.ToString();

			// 強度
			string sRank = numericUpDown2.Value.ToString();

			// パーティクル非表示
			string sHideParticle = "";
			// ラジオボタンの値取得
			foreach (Control ctrl in groupBox1.Controls)
			{
				if (ctrl is RadioButton && ((RadioButton)ctrl).Checked)
				{
					sHideParticle = ctrl.Tag.ToString();
				}
			}
			if (sHideParticle == "")
			{
				sHideParticle = "false";
			}

			// コマンド実行
			string cmd = "";
			cmd += "effect";
			cmd += " " + sPlayer;
			cmd += " " + sEffect;
			cmd += " " + sTime;
			cmd += " " + sRank;
			cmd += " " + sHideParticle;
			appMainForm.fncExecuteCommand(cmd);

		}

		// 解除
		private void button2_Click(object sender, System.EventArgs e)
		{
			// 対象ID
			if (playerSelect1.fncPlayerIsEmpty())
			{
				MessageBox.Show("対象IDを指定してください。");
				return;
			}
			string sPlayer = playerSelect1.fncGetPlayerName();

			// 効果
			ComboBoxEffectItem item = (ComboBoxEffectItem)comboBox1.SelectedItem;
			if (item == null)
			{
				MessageBox.Show("効果を指定してください。");
				return;
			}
			string sEffect = item.entity.ID.ToString();

			// コマンド実行
			string cmd = "";
			cmd += "effect";
			cmd += " " + sPlayer;
			cmd += " " + sEffect;
			cmd += " 0 0";
			appMainForm.fncExecuteCommand(cmd);
		}

		// 全解除
		private void button3_Click(object sender, System.EventArgs e)
		{
			// 対象ID
			if (playerSelect2.fncPlayerIsEmpty())
			{
				MessageBox.Show("対象IDを指定してください。");
				return;
			}
			string sPlayer = playerSelect2.fncGetPlayerName();

			// コマンド実行
			string cmd = "";
			cmd += "effect";
			cmd += " " + sPlayer;
			cmd += " clear";
			appMainForm.fncExecuteCommand(cmd);
		}
	}
}
