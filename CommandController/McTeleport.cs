using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class McTeleport : UserControl
	{
		private AppMainForm refForm;
		//private AutoCompleteStringCollection autoCompList;

		public McTeleport()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
			init();
		}

		private void init()
		{
			//autoCompList = new AutoCompleteStringCollection();
			textBox1.AutoCompleteCustomSource = refForm.autoCompList;
			textBox2.AutoCompleteCustomSource = refForm.autoCompList;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			string newItem;
			newItem = textBox1.Text.Trim();
			refForm.fncAddUser(newItem);
			newItem = textBox2.Text.Trim();
			refForm.fncAddUser(newItem);

			String strOutput = "";
			String fromPlayer = textBox1.Text;
			String toPlayer = textBox2.Text;
			strOutput += "tp " + fromPlayer + " " + toPlayer;
			refForm.fncExecuteCommand(strOutput);
		}
	}
}
