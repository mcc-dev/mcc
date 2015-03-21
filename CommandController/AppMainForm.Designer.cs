namespace CommandController
{
	partial class AppMainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.mcGameMode1 = new CommandController.McGameMode();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.mcTeleport1 = new CommandController.McTeleport();
			this.tabPage8 = new System.Windows.Forms.TabPage();
			this.mcEnchant1 = new CommandController.McEnchant();
			this.tabPage10 = new System.Windows.Forms.TabPage();
			this.mcEffect1 = new CommandController.McEffect();
			this.tabPage9 = new System.Windows.Forms.TabPage();
			this.tabControl2 = new System.Windows.Forms.TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.tabControl3 = new System.Windows.Forms.TabControl();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.skList1 = new CommandController.SkList();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.skTosochu1 = new CommandController.SkTosochu();
			this.tabPage11 = new System.Windows.Forms.TabPage();
			this.tabControl4 = new System.Windows.Forms.TabControl();
			this.tabPage13 = new System.Windows.Forms.TabPage();
			this.heCommand1 = new CommandController.HeCommand();
			this.tabPage14 = new System.Windows.Forms.TabPage();
			this.heDataBase1 = new CommandController.HeDataBase();
			this.tabPage12 = new System.Windows.Forms.TabPage();
			this.appMenuFrame1 = new CommandController.AppMenuFrame();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage8.SuspendLayout();
			this.tabPage10.SuspendLayout();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabControl3.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.tabPage11.SuspendLayout();
			this.tabControl4.SuspendLayout();
			this.tabPage13.SuspendLayout();
			this.tabPage14.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage8);
			this.tabControl1.Controls.Add(this.tabPage10);
			this.tabControl1.Controls.Add(this.tabPage9);
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(614, 385);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.mcGameMode1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(606, 359);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "ゲームモード";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// mcGameMode1
			// 
			this.mcGameMode1.Location = new System.Drawing.Point(3, 3);
			this.mcGameMode1.Name = "mcGameMode1";
			this.mcGameMode1.Size = new System.Drawing.Size(600, 350);
			this.mcGameMode1.TabIndex = 0;
			this.mcGameMode1.Load += new System.EventHandler(this.mcGameMode1_Load);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.mcTeleport1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(606, 359);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "テレポート";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// mcTeleport1
			// 
			this.mcTeleport1.Location = new System.Drawing.Point(0, 0);
			this.mcTeleport1.Name = "mcTeleport1";
			this.mcTeleport1.Size = new System.Drawing.Size(600, 350);
			this.mcTeleport1.TabIndex = 0;
			this.mcTeleport1.Load += new System.EventHandler(this.mcTeleport1_Load);
			// 
			// tabPage8
			// 
			this.tabPage8.Controls.Add(this.mcEnchant1);
			this.tabPage8.Location = new System.Drawing.Point(4, 22);
			this.tabPage8.Name = "tabPage8";
			this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage8.Size = new System.Drawing.Size(606, 359);
			this.tabPage8.TabIndex = 2;
			this.tabPage8.Text = "エンチャント";
			this.tabPage8.UseVisualStyleBackColor = true;
			// 
			// mcEnchant1
			// 
			this.mcEnchant1.Location = new System.Drawing.Point(3, 3);
			this.mcEnchant1.Name = "mcEnchant1";
			this.mcEnchant1.Size = new System.Drawing.Size(600, 350);
			this.mcEnchant1.TabIndex = 0;
			this.mcEnchant1.Load += new System.EventHandler(this.mcEnchant1_Load);
			// 
			// tabPage10
			// 
			this.tabPage10.Controls.Add(this.mcEffect1);
			this.tabPage10.Location = new System.Drawing.Point(4, 22);
			this.tabPage10.Name = "tabPage10";
			this.tabPage10.Size = new System.Drawing.Size(606, 359);
			this.tabPage10.TabIndex = 4;
			this.tabPage10.Text = "エフェクト";
			this.tabPage10.UseVisualStyleBackColor = true;
			// 
			// mcEffect1
			// 
			this.mcEffect1.Location = new System.Drawing.Point(0, 0);
			this.mcEffect1.Name = "mcEffect1";
			this.mcEffect1.Size = new System.Drawing.Size(600, 350);
			this.mcEffect1.TabIndex = 0;
			this.mcEffect1.Load += new System.EventHandler(this.mcEffect1_Load);
			// 
			// tabPage9
			// 
			this.tabPage9.Location = new System.Drawing.Point(4, 22);
			this.tabPage9.Name = "tabPage9";
			this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage9.Size = new System.Drawing.Size(606, 359);
			this.tabPage9.TabIndex = 3;
			this.tabPage9.Text = "スコアボード";
			this.tabPage9.UseVisualStyleBackColor = true;
			// 
			// tabControl2
			// 
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Controls.Add(this.tabPage5);
			this.tabControl2.Controls.Add(this.tabPage11);
			this.tabControl2.Controls.Add(this.tabPage12);
			this.tabControl2.Location = new System.Drawing.Point(2, 29);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.SelectedIndex = 0;
			this.tabControl2.Size = new System.Drawing.Size(622, 411);
			this.tabControl2.TabIndex = 3;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tabControl1);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(614, 385);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Minecraft";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(614, 385);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.Text = "WorldEdit";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.tabControl3);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(614, 385);
			this.tabPage5.TabIndex = 2;
			this.tabPage5.Text = "Skript";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// tabControl3
			// 
			this.tabControl3.Controls.Add(this.tabPage6);
			this.tabControl3.Controls.Add(this.tabPage7);
			this.tabControl3.Location = new System.Drawing.Point(0, 0);
			this.tabControl3.Name = "tabControl3";
			this.tabControl3.SelectedIndex = 0;
			this.tabControl3.Size = new System.Drawing.Size(614, 385);
			this.tabControl3.TabIndex = 2;
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.skList1);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage6.Size = new System.Drawing.Size(606, 359);
			this.tabPage6.TabIndex = 0;
			this.tabPage6.Text = "ファイル一覧";
			this.tabPage6.UseVisualStyleBackColor = true;
			// 
			// skList1
			// 
			this.skList1.Location = new System.Drawing.Point(0, 0);
			this.skList1.Name = "skList1";
			this.skList1.Size = new System.Drawing.Size(600, 350);
			this.skList1.TabIndex = 0;
			this.skList1.Load += new System.EventHandler(this.skList1_Load);
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.skTosochu1);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage7.Size = new System.Drawing.Size(606, 359);
			this.tabPage7.TabIndex = 1;
			this.tabPage7.Text = "逃走中";
			this.tabPage7.UseVisualStyleBackColor = true;
			// 
			// skTosochu1
			// 
			this.skTosochu1.Location = new System.Drawing.Point(3, 3);
			this.skTosochu1.Margin = new System.Windows.Forms.Padding(0);
			this.skTosochu1.Name = "skTosochu1";
			this.skTosochu1.Size = new System.Drawing.Size(600, 350);
			this.skTosochu1.TabIndex = 0;
			this.skTosochu1.Load += new System.EventHandler(this.skTosochu1_Load);
			// 
			// tabPage11
			// 
			this.tabPage11.Controls.Add(this.tabControl4);
			this.tabPage11.Location = new System.Drawing.Point(4, 22);
			this.tabPage11.Name = "tabPage11";
			this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage11.Size = new System.Drawing.Size(614, 385);
			this.tabPage11.TabIndex = 3;
			this.tabPage11.Text = "HawkEye";
			this.tabPage11.UseVisualStyleBackColor = true;
			// 
			// tabControl4
			// 
			this.tabControl4.Controls.Add(this.tabPage13);
			this.tabControl4.Controls.Add(this.tabPage14);
			this.tabControl4.Location = new System.Drawing.Point(0, 0);
			this.tabControl4.Name = "tabControl4";
			this.tabControl4.SelectedIndex = 0;
			this.tabControl4.Size = new System.Drawing.Size(614, 385);
			this.tabControl4.TabIndex = 0;
			// 
			// tabPage13
			// 
			this.tabPage13.Controls.Add(this.heCommand1);
			this.tabPage13.Location = new System.Drawing.Point(4, 22);
			this.tabPage13.Name = "tabPage13";
			this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage13.Size = new System.Drawing.Size(606, 359);
			this.tabPage13.TabIndex = 0;
			this.tabPage13.Text = "操作";
			this.tabPage13.UseVisualStyleBackColor = true;
			// 
			// heCommand1
			// 
			this.heCommand1.Location = new System.Drawing.Point(3, 3);
			this.heCommand1.Name = "heCommand1";
			this.heCommand1.Size = new System.Drawing.Size(600, 350);
			this.heCommand1.TabIndex = 0;
			this.heCommand1.Load += new System.EventHandler(this.heCommand1_Load);
			// 
			// tabPage14
			// 
			this.tabPage14.Controls.Add(this.heDataBase1);
			this.tabPage14.Location = new System.Drawing.Point(4, 22);
			this.tabPage14.Name = "tabPage14";
			this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage14.Size = new System.Drawing.Size(606, 359);
			this.tabPage14.TabIndex = 1;
			this.tabPage14.Text = "DB検索";
			this.tabPage14.UseVisualStyleBackColor = true;
			// 
			// heDataBase1
			// 
			this.heDataBase1.Location = new System.Drawing.Point(3, 3);
			this.heDataBase1.Name = "heDataBase1";
			this.heDataBase1.Size = new System.Drawing.Size(600, 350);
			this.heDataBase1.TabIndex = 0;
			this.heDataBase1.Load += new System.EventHandler(this.heDataBase1_Load);
			// 
			// tabPage12
			// 
			this.tabPage12.Location = new System.Drawing.Point(4, 22);
			this.tabPage12.Name = "tabPage12";
			this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage12.Size = new System.Drawing.Size(614, 385);
			this.tabPage12.TabIndex = 4;
			this.tabPage12.Text = "ShadowAdmin";
			this.tabPage12.UseVisualStyleBackColor = true;
			// 
			// appMenuFrame1
			// 
			this.appMenuFrame1.AutoSize = true;
			this.appMenuFrame1.Dock = System.Windows.Forms.DockStyle.Top;
			this.appMenuFrame1.Location = new System.Drawing.Point(0, 0);
			this.appMenuFrame1.Name = "appMenuFrame1";
			this.appMenuFrame1.Size = new System.Drawing.Size(624, 26);
			this.appMenuFrame1.TabIndex = 4;
			this.appMenuFrame1.Load += new System.EventHandler(this.appMenuFrame1_Load);
			// 
			// AppMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(624, 442);
			this.Controls.Add(this.appMenuFrame1);
			this.Controls.Add(this.tabControl2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AppMainForm";
			this.Text = "Minecraft CommandController v0.6.3";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage8.ResumeLayout(false);
			this.tabPage10.ResumeLayout(false);
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabControl3.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.tabPage11.ResumeLayout(false);
			this.tabControl4.ResumeLayout(false);
			this.tabPage13.ResumeLayout(false);
			this.tabPage14.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabControl tabControl2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabControl tabControl3;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private McGameMode mcGameMode1;
		private McTeleport mcTeleport1;
		private SkList skList1;
		private SkTosochu skTosochu1;
		private System.Windows.Forms.TabPage tabPage8;
		private McEnchant mcEnchant1;
		private System.Windows.Forms.TabPage tabPage9;
		private AppMenuFrame appMenuFrame1;
		private System.Windows.Forms.TabPage tabPage10;
		private McEffect mcEffect1;
		private System.Windows.Forms.TabPage tabPage11;
		private System.Windows.Forms.TabPage tabPage12;
		private System.Windows.Forms.TabControl tabControl4;
		private System.Windows.Forms.TabPage tabPage13;
		private System.Windows.Forms.TabPage tabPage14;
		private HeCommand heCommand1;
		private HeDataBase heDataBase1;
	}
}

