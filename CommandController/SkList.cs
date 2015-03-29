using System;
using System.IO;
using System.Windows.Forms;

namespace CommandController
{
	public partial class SkList : UserControl
	{
		private AppMainForm refForm;
		public String mcDir = @"";

		public SkList()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
			fncGetSkriptList();
		}

		public void fncGetSkriptList()
		{
			checkedListBox1.ItemCheck -= new ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
			checkedListBox1.Items.Clear();

			string skDir = refForm.appSettings.McDir + @"\plugins\Skript\scripts";
			if (System.IO.Directory.Exists(skDir))
			{
				string[] files = Directory.GetFiles(skDir, "*.sk");
				foreach (string s in files)
				{
					String strFileName = Path.GetFileNameWithoutExtension(s);
					Boolean isChecked = (strFileName.StartsWith("-")) ? false : true;
					checkedListBox1.Items.Add(strFileName, isChecked);
				}
			}
			checkedListBox1.ItemCheck += new ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
		}

		private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			String s = this.checkedListBox1.Items[e.Index] as String;
			if (s.StartsWith("-"))
			{
				s = s.Substring(1);
			}
			String strOpe = (e.NewValue.ToString() == "Checked") ? "enable" : "disable";
			String strOutput = "skript " + strOpe + " " + s;
			refForm.fncExecuteCommand(strOutput);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			fncGetSkriptList();
		}

	}
}
