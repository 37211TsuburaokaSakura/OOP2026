using System.ComponentModel;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReport = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReport;
        }

        //追加ボタンイベントハンドラ
        public void btAddRecord_Click(object sender, EventArgs e) {

            tsslbMessage.Text = string.Empty;

            /***********************************************************/
            if (cbAuthor.Text == string.Empty || cbCarName.Text == string.Empty) {
                tsslbMessage.Text = "記入者、または車名が未入力です。";

                return;
            }



            /********************************************************/

            var carReport = new CarReport {
                Date = dtpDate.Value, //日付
                Author = cbAuthor.Text, //記録者
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text, //車名
                Report = tbReport.Text, //レポート
                Picture = pdPicture.Image, //画像

            };
            listCarReport.Add(carReport);


            ImputItemsAllClear();
        }
        private MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked)
                return MakerGroup.トヨタ;
            if (rbSubaru.Checked)
                return MakerGroup.スバル;
            if (rbNissan.Checked)
                return MakerGroup.日産;
            if (rbImport.Checked)
                return MakerGroup.輸入車;
            if (rbHonda.Checked)
                return MakerGroup.ホンダ;
            else

                return MakerGroup.その他;
        }

        private void btPicOpen_Click(object sender, EventArgs e) {
            if (ofdPickFileOpen.ShowDialog() == DialogResult.OK) {
                pdPicture.Image = Image.FromFile(ofdPickFileOpen.FileName);
            }
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            ImputItemsAllClear();

        }

        private void ImputItemsAllClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = string.Empty;
            rbOther.Checked = true;
            cbCarName.Text = string.Empty;
            tbReport.Text = string.Empty;
            pdPicture.Image = null;
        }

        private void dgvRecords_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;

            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["Name"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pdPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
        }

        
    }
}
