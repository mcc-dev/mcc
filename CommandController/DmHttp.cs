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
		public class DynmapWorldJson
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

		public class DynmapConfigJson
		{
			public class Center
			{
				public double z { get; set; }
				public double y { get; set; }
				public double x { get; set; }
			}
			public class Map
			{
				public bool nightandday { get; set; }
				public List<double> worldtomap { get; set; }
				public int scale { get; set; }
				public int mapzoomin { get; set; }
				public string shader { get; set; }
				public List<double> maptoworld { get; set; }
				public bool bigmap { get; set; }
				public int inclination { get; set; }
				public string type { get; set; }
				public int mapzoomout { get; set; }
				public string title { get; set; }
				public bool @protected { get; set; }
				public string lighting { get; set; }
				public string name { get; set; }
				public string prefix { get; set; }
				public int boostzoom { get; set; }
				public string compassview { get; set; }
				public string perspective { get; set; }
				public int azimuth { get; set; }
				//public string __invalid_name__image-format { get; set; }
				public string background { get; set; }
			}
			public class World
			{
				public Center center { get; set; }
				public int extrazoomout { get; set; }
				public string title { get; set; }
				public int worldheight { get; set; }
				public bool @protected { get; set; }
				public List<Map> maps { get; set; }
				public int sealevel { get; set; }
				public string name { get; set; }
			}
			/*
			public class Component
			{
				public bool offlinehidebydefault { get; set; }
				public bool showspawnbeds { get; set; }
				public string spawnicon { get; set; }
				public int spawnbedminzoom { get; set; }
				public string offlinelabel { get; set; }
				public bool showspawn { get; set; }
				public string spawnbedicon { get; set; }
				public bool showlabel { get; set; }
				public int maxofflinetime { get; set; }
				public string spawnbedformat { get; set; }
				public bool spawnbedhidebydefault { get; set; }
				public string spawnbedlabel { get; set; }
				public string spawnlabel { get; set; }
				public int offlineminzoom { get; set; }
				public bool enablesigns { get; set; }
				public bool showofflineplayers { get; set; }
				public string type { get; set; }
				public bool? allowurlname { get; set; }
				public bool? focuschatballoons { get; set; }
				public int? messagettl { get; set; }
				public bool? sendbutton { get; set; }
				public bool? showplayerfaces { get; set; }
				public int? layerprio { get; set; }
				public bool? smallplayerfaces { get; set; }
				public string label { get; set; }
				public bool? showplayerbody { get; set; }
				public bool? showplayerhealth { get; set; }
				public bool? hidebydefault { get; set; }
				public bool? showdigitalclock { get; set; }
				public bool? showweather { get; set; }
				public bool? hidey { get; set; }
				public bool? __invalid_name__show-mcr { get; set; }
			}
			 * */
			//public bool __invalid_name__login-enabled { get; set; }
			public int maxcount { get; set; }
			//public string __invalid_name__msg-hiddennamejoin { get; set; }
			//public bool __invalid_name__webchat-requires-login { get; set; }
			public string quitmessage { get; set; }
			public int confighash { get; set; }
			public List<World> worlds { get; set; }
			public string showlayercontrol { get; set; }
			public string title { get; set; }
			public string defaultmap { get; set; }
			public bool showplayerfacesinmenu { get; set; }
			//public string __invalid_name__msg-players { get; set; }
			//public string __invalid_name__msg-chatnotallowed { get; set; }
			public int chatlengthlimit { get; set; }
			public bool cyrillic { get; set; }
			public bool loginrequired { get; set; }
			public string webprefix { get; set; }
			public string coreversion { get; set; }
			public bool allowchat { get; set; }
			public string dynmapversion { get; set; }
			public string sidebaropened { get; set; }
			public int updaterate { get; set; }
			public bool jsonfile { get; set; }
			//public string __invalid_name__msg-maptypes { get; set; }
			public int defaultzoom { get; set; }
			public string defaultworld { get; set; }
			public string spammessage { get; set; }
			public string joinmessage { get; set; }
			public bool grayplayerswhenhidden { get; set; }
			//public int __invalid_name__webchat-interval { get; set; }
			public bool allowwebchat { get; set; }
			//public List<Component> components { get; set; }
			//public string __invalid_name__msg-chatrequireslogin { get; set; }
			//public string __invalid_name__msg-hiddennamequit { get; set; }
		}

		private AppMainForm refForm;
		DynmapWorldJson objResWorldJson;
		DynmapConfigJson objResConfigJson;

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
			//string sReqUrl = sBaseUrl + "up/world/SSMR/1";
			string sReqUrl = sBaseUrl + "standalone/world/SSMR.json?_=1";

			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sReqUrl);
			req.Method = "GET";

			using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
			{
				using (Stream resStream = res.GetResponseStream())
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DynmapWorldJson));
					this.objResWorldJson = (DynmapWorldJson)serializer.ReadObject(resStream);
				}
			}

			listBox1.Items.Clear();
			foreach (DynmapWorldJson.Player player in objResWorldJson.players)
			{
				listBox1.Items.Add(player.name);
				refForm.fncAddUser(player.name);
				//if (!String.IsNullOrEmpty(player.world) && !refForm.appData.world.WorldList.Contains(player.world))
				//{
				//	refForm.appData.world.WorldList.Add(player.world);
				//}

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

		private void button2_Click(object sender, EventArgs e)
		{
			string sBaseUrl = textBox1.Text;
			string sReqUrl = sBaseUrl + "standalone/dynmap_config.json?_={timestamp}";

			HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sReqUrl);
			req.Method = "GET";

			using (HttpWebResponse res = (HttpWebResponse)req.GetResponse())
			{
				using (Stream resStream = res.GetResponseStream())
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(DynmapConfigJson));
					this.objResConfigJson = (DynmapConfigJson)serializer.ReadObject(resStream);
				}
			}

			listBox2.Items.Clear();
			foreach (DynmapConfigJson.World world in objResConfigJson.worlds)
			{
				listBox2.Items.Add(world.name);
				if (!String.IsNullOrEmpty(world.name) && !refForm.appData.world.WorldList.Contains(world.name))
				{
					refForm.appData.world.WorldList.Add(world.name);
				}

			}

		}
	}
}
