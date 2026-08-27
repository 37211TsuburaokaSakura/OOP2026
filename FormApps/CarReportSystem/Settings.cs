using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public sealed class Settings {

        private const string FileName = "setting.xml";
        //唯一のSettingオブぜくと
        private static readonly Settings _instance = new Settings();

        //メイン画面に設定した色情報する
        public int MainFormBackColor { get; set; }
        = SystemColors.Control.ToArgb();

        //唯一のオブジェクトを取得する
        public static Settings Instance {
            get { return _instance; }
        }

        //外部からnewさせないようにする
        private Settings() { }

        //設定ファイルからロード
        public void Load() {
            if (!File.Exists(FileName))
                return;

            using var reader = XmlReader.Create(("setting.xml"));
            var serializer = new XmlSerializer(typeof(SettingsData));

            if (serializer.Deserialize(reader) is  SettingsData data) {
                MainFormBackColor = data.MainFormBackColor;

            }
        }

        //設定ファイルのセーブ
        public void Save() {
            var data = new SettingsData {
                MainFormBackColor = MainFormBackColor
            };
            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsData));
            serializer.Serialize(writer, data);

        }
        //xml保存用のクラス
        public class SettingsData {
            public int MainFormBackColor { get; set; }
        }
    }
}
