namespace CommandController
{
	partial class DmHttp
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 19);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "http://ssmrprpr.com:8123/";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(4, 29);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "プレイヤー取得";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(4, 58);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(120, 268);
			this.listBox1.TabIndex = 2;
			this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 329);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "※とりあえずオートコンプリートに追加します";
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(130, 58);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(120, 268);
			this.listBox2.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(130, 29);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 23);
			this.button2.TabIndex = 5;
			this.button2.Text = "ワールド取得";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// DmHttp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Name = "DmHttp";
			this.Size = new System.Drawing.Size(600, 350);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button2;
	}
}
