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
			if (refForm.appSettings.ExcuteType == 1)
			{
				if (TargetWindow.fncFindMinecraft())
				{
					Clipboard.SetDataObject(textBox1.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
					Clipboard.SetDataObject(textBox2.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
					Clipboard.SetDataObject(textBox3.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
					Clipboard.SetDataObject(textBox4.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
				}
			}
			else if (refForm.appSettings.ExcuteType == 4)
			{
				if (TargetWindow.fncFindNotepad())
				{
					Clipboard.SetDataObject(textBox1.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
					Clipboard.SetDataObject(textBox2.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
					Clipboard.SetDataObject(textBox3.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
					Clipboard.SetDataObject(textBox4.Text);
					Win32API.keybd_paste();
					Win32API.keybd_click(Win32API.VK_RETURN);
				}

			}
		}

	}
}
