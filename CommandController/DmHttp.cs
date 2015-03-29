using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

namespace CommandController
{
	public partial class DmHttp : UserControl
	{
		public class ResponseJson
		{
			public class Player
			{
				public string world { get; set; }
				public int armor { get; set; }
				public string name { get; set; }
				public double x { get; set; }
				public double y { get; set; }
				public double health { get; set; }
				public double z { get; set; }
				public int sort { get; set; }
				public string type { get; set; }
				public string account { get; set; }
			}
			//public class Update
			//{
			//	public string type { get; set; }
			//	public string name { get; set; }
			//	public object timestamp { get; set; }
			//	public string playerName { get; set; }
			//	public string account { get; set; }
			//}
			public int currentcount { get; set; }
			public bool hasStorm { get; set; }
			public List<Player> players { get; set; }
			public bool isThundering { get; set; }
			public int confighash { get; set; }
			public int servertime { get; set; }
			//public List<Update> updates { get; set; }
			public long timestamp { get; set; }
		}

		private AppMainForm refForm;
		ResponseJson objResJson;

		public DmHttp()
		{
			InitializeComponent();
			fncInit();
		}

		public void fncSetRefForm(AppMainForm fm)
		{
			this.refForm = fm;
			fncInit();
		}

		private void fncInit()
		{
			
		}

		private bool fncConfirm(string message)
		{
			//メッセージボックスを表示する
			DialogResult result = MessageBox.Show(
				message,
				"確認",
				MessageBoxButtons.YesNo);

			//何が選択されたか調べる
			if (result == DialogResult.Yes)
			{
				//「はい」が選択された時
				return true;
			}
			else
			{
				//「いいえ」が選択された時
				return false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string sBaseUrl = textBox1.Text;
			string sReqUrl = sBaseUrl + "up/world/SSMR/1";

			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sReqUrl);
			req.Method = "GET";

			using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
			{
				using (Stream resStream = res.GetResponseStream())
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ResponseJson));
					this.objResJson = (ResponseJson)serializer.ReadObject(resStream);
				}
			}

			listBox1.Items.Clear();
			foreach (ResponseJson.Player player in objResJson.players)
			{
				listBox1.Items.Add(player.name);
				refForm.fncAddUser(player.name);
				if (!String.IsNullOrEmpty(player.world) && !refForm.appData.world.WorldList.Contains(player.world))
				{
					refForm.appData.world.WorldList.Add(player.world);
				}

			}
		}

		private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			string selectPlayer = listBox1.SelectedItem.ToString();
			string message = selectPlayer + "にテレポートします。よろしいですか？";
			//確認後実行
			if (fncConfirm(message))
			{
				string strOutput = "";
				strOutput += "tp " + selectPlayer;
				refForm.fncExecuteCommand(strOutput);
			}
		}
	}
}
