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
		static private String fileName = @"settings.config";
		static private SettingDataEt settings = new SettingDataEt();

		static public void SaveSettings()
		{
			//＜XMLファイルに書き込む＞
			//XmlSerializerオブジェクトを作成
			//書き込むオブジェクトの型を指定する
			XmlSerializer serializer1 = new XmlSerializer(typeof(SettingDataEt));
			//ファイルを開く（UTF-8 BOM無し）
			StreamWriter sw = new StreamWriter(fileName, false, new UTF8Encoding(false));
			//シリアル化し、XMLファイルに保存する
			serializer1.Serialize(sw, settings);
			//閉じる
			sw.Close();
		}

		static public void SaveSettings(SettingDataEt data)
		{
			settings = data;
			SaveSettings();
		}

		static public SettingDataEt LoadSettings()
		{
			//SettingDataEt data = new SettingDataEt();
			if (!File.Exists(fileName))
			{
				return settings;
			}
			//＜XMLファイルから読み込む＞
			//XmlSerializerオブジェクトの作成
			XmlSerializer serializer2 = new XmlSerializer(typeof(SettingDataEt));
			//ファイルを開く
			StreamReader sr = new StreamReader(fileName, new UTF8Encoding(false));
			//XMLファイルから読み込み、逆シリアル化する
			settings = (SettingDataEt)serializer2.Deserialize(sr);
			//閉じる
			sr.Close();

			return settings;
		}

		static public SettingDataEt ReferSettings()
		{
			return settings;
		}

	}
}
