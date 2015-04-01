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
    public partial class SaCommand : UserControl
    {
        private AppMainForm refForm;
        
        public SaCommand()
        {
            InitializeComponent();
        }
        
        public void fncSetRefForm(AppMainForm fm)
        {
            this.refForm = fm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strOutput = "";
            strOutput += "sd ents list";
            refForm.fncExecuteCommand(strOutput); //いろいろ参考に書いてみたがぬるぽが出る
        }

    }
}
