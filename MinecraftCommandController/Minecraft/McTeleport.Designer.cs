namespace MinecraftCommandController.Minecraft
{
	partial class McTeleport
	{
		/// <summary> 
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.playerSelect2 = new MinecraftCommandController.Util.PlayerSelect();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.playerSelect3 = new MinecraftCommandController.Util.PlayerSelect();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.playerSelect5 = new MinecraftCommandController.Util.PlayerSelect();
			this.label3 = new System.Windows.Forms.Label();
			this.playerSelect4 = new MinecraftCommandController.Util.PlayerSelect();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.playerSelect1);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(514, 50);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "自身";
			// 
			// playerSelect1
			// 
			this.playerSelect1.Location = new System.Drawing.Point(3, 15);
			this.playerSelect1.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect1.Name = "playerSelect1";
			this.playerSelect1.Size = new System.Drawing.Size(155, 31);
			this.playerSelect1.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.playerSelect2);
			this.groupBox2.Location = new System.Drawing.Point(3, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(514, 50);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "向かう";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(468, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "実行";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "誰に :";
			// 
			// playerSelect2
			// 
			this.playerSelect2.Location = new System.Drawing.Point(41, 15);
			this.playerSelect2.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect2.Name = "playerSelect2";
			this.playerSelect2.Size = new System.Drawing.Size(155, 31);
			this.playerSelect2.TabIndex = 1;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button2);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.playerSelect3);
			this.groupBox3.Location = new System.Drawing.Point(3, 115);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(514, 50);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "呼ぶ";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(468, 18);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "実行";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "誰を :";
			// 
			// playerSelect3
			// 
			this.playerSelect3.Location = new System.Drawing.Point(41, 15);
			this.playerSelect3.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect3.Name = "playerSelect3";
			this.playerSelect3.Size = new System.Drawing.Size(155, 31);
			this.playerSelect3.TabIndex = 1;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.button3);
			this.groupBox4.Controls.Add(this.playerSelect5);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.playerSelect4);
			this.groupBox4.Location = new System.Drawing.Point(3, 171);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(514, 50);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "向かわせる";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(202, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 2;
			this.label4.Text = "誰に :";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(468, 18);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "実行";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// playerSelect5
			// 
			this.playerSelect5.Location = new System.Drawing.Point(237, 15);
			this.playerSelect5.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect5.Name = "playerSelect5";
			this.playerSelect5.Size = new System.Drawing.Size(155, 31);
			this.playerSelect5.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "誰を :";
			// 
			// playerSelect4
			// 
			this.playerSelect4.Location = new System.Drawing.Point(41, 15);
			this.playerSelect4.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect4.Name = "playerSelect4";
			this.playerSelect4.Size = new System.Drawing.Size(155, 31);
			this.playerSelect4.TabIndex = 1;
			// 
			// McTeleport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "McTeleport";
			this.Size = new System.Drawing.Size(520, 380);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Util.PlayerSelect playerSelect1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Util.PlayerSelect playerSelect2;
		private System.Windows.Forms.GroupBox groupBox3;
		private Util.PlayerSelect playerSelect3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button3;
		private Util.PlayerSelect playerSelect5;
		private System.Windows.Forms.Label label3;
		private Util.PlayerSelect playerSelect4;
	}
}
