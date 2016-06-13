using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MinecraftCommandController.Setting
{
	static class SettingAction
	{
		//保存先のファイル名
		static public String fileName = @"settings.config";

		static public void SaveSettings(SettingDataEt data)
		{
			//＜XMLファイルに書き込む＞
			//XmlSerializerオブジェクトを作成
			//書き込むオブジェクトの型を指定する
			XmlSerializer serializer1 = new XmlSerializer(typeof(SettingDataEt));
			//ファイルを開く（UTF-8 BOM無し）
			StreamWriter sw = new StreamWriter(fileName, false, new UTF8Encoding(false));
			//シリアル化し、XMLファイルに保存する
			serializer1.Serialize(sw, data);
			//閉じる
			sw.Close();
		}

		static public SettingDataEt LoadSettings()
		{
			SettingDataEt data = new SettingDataEt();
			if (!File.Exists(fileName))
			{
				return data;
			}
			//＜XMLファイルから読み込む＞
			//XmlSerializerオブジェクトの作成
			XmlSerializer serializer2 = new XmlSerializer(typeof(SettingDataEt));
			//ファイルを開く
			StreamReader sr = new StreamReader(fileName, new UTF8Encoding(false));
			//XMLファイルから読み込み、逆シリアル化する
			data = (SettingDataEt)serializer2.Deserialize(sr);
			//閉じる
			sr.Close();

			return data;
		}

	}
}
