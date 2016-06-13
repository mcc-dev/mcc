namespace MinecraftCommandController.Setting
{
	partial class AppSettingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("全般");
			System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("サーバー連携");
			System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("データソース");
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("環境", new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode18,
            treeNode19});
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Skript");
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("HawkEye");
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("ShadowAdmin");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("プラグイン", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22,
            treeNode23});
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.treeView1.Location = new System.Drawing.Point(12, 12);
			this.treeView1.Name = "treeView1";
			treeNode17.Name = "ノード3";
			treeNode17.Text = "全般";
			treeNode18.Name = "ノード6";
			treeNode18.Text = "サーバー連携";
			treeNode19.Name = "ノード7";
			treeNode19.Text = "データソース";
			treeNode20.Checked = true;
			treeNode20.Name = "ノード0";
			treeNode20.Text = "環境";
			treeNode21.Name = "ノード4";
			treeNode21.Text = "Skript";
			treeNode22.Name = "ノード5";
			treeNode22.Text = "HawkEye";
			treeNode23.Name = "ノード8";
			treeNode23.Text = "ShadowAdmin";
			treeNode24.Name = "ノード2";
			treeNode24.Text = "プラグイン";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode24});
			this.treeView1.Size = new System.Drawing.Size(154, 358);
			this.treeView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(376, 347);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(457, 347);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "キャンセル";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(172, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 320);
			this.panel1.TabIndex = 3;
			// 
			// AppSettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(544, 382);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.treeView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "AppSettingForm";
			this.Text = "設定";
			this.Load += new System.EventHandler(this.AppSettingForm_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
	}
}