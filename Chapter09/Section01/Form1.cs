using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpdate.Value;
            tbOut.Text = date.AddDays((double)nudDay.Value).ToString();

        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth =dtpBirth.Value;  //生まれた日付
            DateTime today = DateTime.Today; //今日の日付

            var birthday = today.Year- birth.Year;
            var longago = today.Date - birth.Date;
            if (today < birth.AddYears(birthday)) {
                birthday--;
            }
            tbOut.Text = $"あなたは{GetAge(birth, today)}歳";
            tbOut2.Text = $"経過日数は{longago.Days}です";

            //年齢を求めるメソッド
            static int GetAge(DateTime birthday, DateTime targetDay) {
                var age = targetDay.Year - birthday.Year;
                if (targetDay < birthday.AddYears(age)) {
                    age--;
                }
                return age;
            }
        }
    }
}
