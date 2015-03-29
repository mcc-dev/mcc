using System;
using System.Windows.Forms;

namespace CommandController
{
	public partial class McSign : UserControl
	{
		private AppMainForm refForm;

		public McSign()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Win32API.keybd_click(Win32API.VK_ESCAPE);
		}

	}
}
