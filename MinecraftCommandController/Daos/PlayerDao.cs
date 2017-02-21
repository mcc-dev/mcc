using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Collections.Generic;

using MinecraftCommandController.Entities;

namespace MinecraftCommandController.Daos
{
	public class PlayerDao
	{
		public PlayerDao()
		{

		}

		public void SaveXml(PlayerCollectionEt list, string filepath)
		{
			//＜XMLファイルに書き込む＞
			//XmlSerializerオブジェクトを作成
			//書き込むオブジェクトの型を指定する
			XmlSerializer serializer1 = new XmlSerializer(typeof(PlayerCollectionEt));
			//ファイルを開く（UTF-8 BOM無し）
			StreamWriter sw = new StreamWriter(filepath, false, new UTF8Encoding(false));
			//シリアル化し、XMLファイルに保存する
			serializer1.Serialize(sw, list);
			//閉じる
			sw.Close();
		}

		public PlayerCollectionEt LoadXml(string filepath)
		{
			PlayerCollectionEt list;
			if (!File.Exists(filepath))
			{
				return null;
			}
			//＜XMLファイルから読み込む＞
			//XmlSerializerオブジェクトの作成
			XmlSerializer serializer2 = new XmlSerializer(typeof(PlayerCollectionEt));
			//ファイルを開く
			StreamReader sr = new StreamReader(filepath, new UTF8Encoding(false));
			//XMLファイルから読み込み、逆シリアル化する
			list = (PlayerCollectionEt)serializer2.Deserialize(sr);
			//閉じる
			sr.Close();

			return list;
		}
	}
}
