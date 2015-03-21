using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CommandController
{
	public partial class AppMenuFrame : UserControl
	{
		private AppMainForm refForm;

		public AppMenuFrame()
		{
			InitializeComponent();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
		}

		private void toolStripMenuItem2_Click(object sender, EventArgs e)
		{
			AppSettingForm f2 = new AppSettingForm(refForm);
			f2.ShowDialog(); 
		}

		private void toolStripMenuItem3_Click(object sender, EventArgs e)
		{
			HeSettingForm f2 = new HeSettingForm(refForm);
			f2.ShowDialog();
		}
	}
}
