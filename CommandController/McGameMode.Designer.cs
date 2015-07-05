namespace CommandController
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 43);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "サバイバル";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(92, 43);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(80, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "クリエイティブ";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(178, 43);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(80, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "アドベンチャー";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(264, 43);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "スペクテイター";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// textBox1
			// 
			this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.textBox1.Location = new System.Drawing.Point(58, 18);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 19);
			this.textBox1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "対象ID：";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(362, 77);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ゲームモード";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button8);
			this.groupBox2.Controls.Add(this.button7);
			this.groupBox2.Controls.Add(this.button6);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Location = new System.Drawing.Point(3, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(362, 54);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "難易度";
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(6, 18);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(80, 23);
			this.button5.TabIndex = 0;
			this.button5.Text = "ピースフル";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(92, 18);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(80, 23);
			this.button6.TabIndex = 1;
			this.button6.Text = "イージー";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(178, 18);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(80, 23);
			this.button7.TabIndex = 2;
			this.button7.Text = "ノーマル";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(264, 18);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(80, 23);
			this.button8.TabIndex = 3;
			this.button8.Text = "ハード";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// McGameMode
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "McGameMode";
			this.Size = new System.Drawing.Size(600, 350);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
	}
}
