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

            SetCbAuthor(cbAuthor.Text); //////////////////////////////////////////////
            SetCbName(cbCarName.Text);

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
            if (dgvRecords.CurrentRow is null) return;


            dtpDate.Value = (DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;
            SetRadioButtonMaker((MakerGroup)dgvRecords.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pdPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
        }

        private void SetRadioButtonMaker(MakerGroup targetMaker) {
            switch (targetMaker) {
                case MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                default:
                    rbOther.Checked = true;
                    break;
            }
        }

        //記録者の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbAuthor(string author) {

            if (!cbAuthor.Items.Contains(author)) {
                cbAuthor.Items.Add(author);
                
            }
        }


        //車名の入力履歴をコンボボックスへ登録（重複なし）
        private void SetCbName(string carname) {

            if (!cbCarName.Items.Contains(carname)) {
                cbCarName.Items.Add(carname);
            }
        }
    }
}