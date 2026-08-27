using System.Xml;
using System.Xml.Serialization;

namespace CarReportSystem {
    public sealed class Settings {

        private const string FileName = "setting.xml";
        //唯一のSettingオブぜくと
        private static readonly Settings _instance = new Settings();

        //メイン画面に設定した色情報
        public int MainFormBackColor { get; set; }
        = SystemColors.Control.ToArgb();

        //唯一のオブジェクトを取得する
        public static Settings Instance {
            get { return _instance; }
        }

        //外部からnewさせないようにする
        private Settings() { }

        //ロード
        public void Load() {
            if (File.Exists(FileName))
                return;
            using var reader = XmlReader.Create(("setting.xml"));
            var serializer = new XmlSerializer(typeof(SettingsDate));

            if (serializer.Deserialize(reader) is Settings date) {
                MainFormBackColor = date.MainFormBackColor;

            }
        }

        //セーブ
        public void Save() {
            var date = new SettingsDate {
                MainForBackColor = MainFormBackColor
            };
            using var writer = XmlWriter.Create(FileName);
            var serializer = new XmlSerializer(typeof(SettingsDate));
            serializer.Serialize(writer, date);

        }
        //xml保存用のクラス
        public class SettingsDate {
            public int MainForBackColor { get; set; }
        }
    }
}
