﻿namespace MinecraftCommandController.Contents.Minecraft
{
	partial class McGameMode
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

		#region コンポーネント デザイナーで生成されたコード

		/// <summary> 
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.playerSelect1 = new MinecraftCommandController.Util.PlayerSelect();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.playerSelect2 = new MinecraftCommandController.Util.PlayerSelect();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.playerSelect1);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(514, 80);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ゲームモード";
			// 
			// playerSelect1
			// 
			this.playerSelect1.Location = new System.Drawing.Point(55, 11);
			this.playerSelect1.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect1.Name = "playerSelect1";
			this.playerSelect1.Size = new System.Drawing.Size(155, 29);
			this.playerSelect1.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(264, 43);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "スペクテイター";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(178, 43);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "アドベンチャー";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(92, 43);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "クリエイティブ";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "サバイバル";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "対象ID：";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.playerSelect2);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(3, 89);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(514, 80);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "コマンドブロック";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(104, 47);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(90, 23);
			this.button6.TabIndex = 8;
			this.button6.Text = "コマンドトロッコ";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(8, 47);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(90, 23);
			this.button5.TabIndex = 6;
			this.button5.Text = "コマンドブロック";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// playerSelect2
			// 
			this.playerSelect2.Location = new System.Drawing.Point(55, 15);
			this.playerSelect2.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect2.Name = "playerSelect2";
			this.playerSelect2.Size = new System.Drawing.Size(155, 29);
			this.playerSelect2.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "対象ID：";
			// 
			// McGameMode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "McGameMode";
			this.Size = new System.Drawing.Size(520, 380);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private Util.PlayerSelect playerSelect1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private Util.PlayerSelect playerSelect2;
		private System.Windows.Forms.Label label2;
	}
}
