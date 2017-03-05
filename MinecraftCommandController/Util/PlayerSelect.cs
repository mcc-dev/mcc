using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftCommandController.Util
{
	public partial class PlayerSelect : UserControl
	{
		public PlayerSelect()
		{
			InitializeComponent();
		}

		public string fncGetPlayerName()
		{
			return textBox1.Text.Trim();
		}

		public bool fncPlayerIsEmpty()
		{
			if (textBox1.Text.Trim() == "")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public void fncSetPlayerName(string player)
		{
			textBox1.Text = player;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			PlayerSelectForm form = new PlayerSelectForm(this);
			form.StartPosition = FormStartPosition.CenterParent;
			form.ShowDialog();
		}
	}
}
