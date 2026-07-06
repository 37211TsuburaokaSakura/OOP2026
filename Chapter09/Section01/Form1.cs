namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime dt1 = dtpdate.Value;

            if (DateTime.IsLeapYear(dt1.Year)) {
                tbOut.Text = "‚¤‚é‚¤”N‚Å‚·";
            } else {
                tbOut.Text = "‚¤‚é‚¤”N‚Å‚Í‚ ‚è‚Ü‚¹‚ñ";

            }

           /*    switch (dt1.DayOfWeek) {
                    case DayOfWeek.Sunday:
                        tbOut.Text = "¡“ú‚Í“ú—j“ú";
                        break;
                    case DayOfWeek.Monday:
                        tbOut.Text = "¡“ú‚ÍŒ—j“ú";
                        break;
                    case DayOfWeek.Tuesday:
                        tbOut.Text = "¡“ú‚Í‰Î—j“ú";
                        break;
                    case DayOfWeek.Wednesday:
                        tbOut.Text = "¡“ú‚Í…—j“ú";
                        break;
                    case DayOfWeek.Thursday:
                        tbOut.Text = "¡“ú‚Í–Ø—j“ú";
                        break;
                    case DayOfWeek.Friday:
                        tbOut.Text = "¡“ú‚Í‹à—j“ú";
                        break;
                    case DayOfWeek.Saturday:
                        tbOut.Text = "¡“ú‚Í—j“ú";
                        break;
                }*/

        }
    }
}
