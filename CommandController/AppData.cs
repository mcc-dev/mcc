using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace CommandController
{
	public class AppData
	{
		public class User
		{
			public ArrayList UserList { get; set; } //ユーザーリスト
			public User()
			{
				UserList = new ArrayList();
			}
		}

		public class World
		{
			public ArrayList WorldList { get; set; } //ワールドリスト
			public World()
			{
				WorldList = new ArrayList();
			}
		}

		public class Teleport
		{
			public List<BookMark> BookMarkList { get; set; }
			public Teleport()
			{
				BookMarkList = new List<BookMark>();
			}
			public class BookMark
			{
				public string name { get; set; }
				public int xPos { get; set; }
				public int yPos { get; set; }
				public int zPos { get; set; }
				public string remark { get; set; }
			}
		}

		private string dirPath = @"data";
		private string pathUser = @"data\user.xml";
		private string pathWorld = @"data\world.xml";
		private string pathTeleport = @"data\teleport.xml";

		public User user { get; set; }
		public World world { get; set; }
		public Teleport teleport { get; set; }

		public AppData()
		{
			if (!Directory.Exists(dirPath))
			{
				Directory.CreateDirectory(dirPath);
			}
			user = new User();
			world = new World();
			teleport = new Teleport();
		}

		public void SaveAll()
		{
			SaveData(this.pathUser, this.user);
			SaveData(this.pathWorld, this.world);
			SaveData(this.pathTeleport, this.teleport);
		}

		public void LoadAll()
		{
			LoadData(this.pathUser, this.user);
			LoadData(this.pathWorld, this.world);
			LoadData(this.pathTeleport, this.teleport);
		}

		public void SaveData(string fileName, object objData)
		{
			//＜XMLファイルに書き込む＞
			//XmlSerializerオブジェクトを作成
			//書き込むオブジェクトの型を指定する
			XmlSerializer serializer1 = new XmlSerializer(objData.GetType());
			//ファイルを開く（UTF-8 BOM無し）
			StreamWriter sw = new StreamWriter(fileName, false, new UTF8Encoding(false));
			//シリアル化し、XMLファイルに保存する
			serializer1.Serialize(sw, objData);
			//閉じる
			sw.Close();
		}

		public void LoadData(string fileName, object objData)
		{
			if (!File.Exists(fileName))
			{
				return;
			}
			Type type = objData.GetType();
			//＜XMLファイルから読み込む＞
			//XmlSerializerオブジェクトの作成
			XmlSerializer serializer2 = new XmlSerializer(type);
			//ファイルを開く
			StreamReader sr = new StreamReader(fileName, new UTF8Encoding(false));
			//XMLファイルから読み込み、逆シリアル化する
			switch (type.Name)
			{
				case "User":
					user = (User)serializer2.Deserialize(sr);
					break;
				case "World":
					world = (World)serializer2.Deserialize(sr);
					break;
				case "Teleport":
					teleport = (Teleport)serializer2.Deserialize(sr);
					break;
				default:
					break;
			}
			//閉じる
			sr.Close();
		}
	}
}
