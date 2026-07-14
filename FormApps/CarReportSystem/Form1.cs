using System.ComponentModel;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReport;
        }

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {

            tsslbMessage.Text = string.Empty;

            /***********************************************************/
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tsslbMessage.Text = "記入者、または車名が未入力です。";

                //return;
            } else {



                /********************************************************/

                var carReport = new CarReport {
                    Date = dtpDate.Value, //日付
                    Author = cbAuthor.Text, //記録者
                    CarName = cbCarName.Text, //車名
                    Report = tbReport.Text, //レポート
                    Picture = pdPicture.Image, //画像



                };
                listCarReport.Add(carReport);
            }
        }
    }
}
