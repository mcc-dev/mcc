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
			this.playerSelect2 = new MinecraftCommandController.Util.PlayerSelect();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.playerSelect3 = new MinecraftCommandController.Util.PlayerSelect();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.groupBox2.Controls.Add(this.playerSelect2);
			this.groupBox2.Location = new System.Drawing.Point(3, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(514, 50);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "向かう";
			// 
			// playerSelect2
			// 
			this.playerSelect2.Location = new System.Drawing.Point(3, 15);
			this.playerSelect2.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect2.Name = "playerSelect2";
			this.playerSelect2.Size = new System.Drawing.Size(155, 31);
			this.playerSelect2.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.playerSelect3);
			this.groupBox3.Location = new System.Drawing.Point(3, 115);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(514, 50);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "呼ぶ";
			// 
			// playerSelect3
			// 
			this.playerSelect3.Location = new System.Drawing.Point(3, 15);
			this.playerSelect3.Margin = new System.Windows.Forms.Padding(0);
			this.playerSelect3.Name = "playerSelect3";
			this.playerSelect3.Size = new System.Drawing.Size(155, 31);
			this.playerSelect3.TabIndex = 0;
			// 
			// McTeleport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "McTeleport";
			this.Size = new System.Drawing.Size(520, 380);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private Util.PlayerSelect playerSelect1;
		private System.Windows.Forms.GroupBox groupBox2;
		private Util.PlayerSelect playerSelect2;
		private System.Windows.Forms.GroupBox groupBox3;
		private Util.PlayerSelect playerSelect3;
	}
}
