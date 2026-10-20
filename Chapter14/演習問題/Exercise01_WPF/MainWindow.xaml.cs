using Microsoft.Win32;
using System.Data.Common;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Console;

namespace Exercise01_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e) {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() is true) {
                TextArea.Text = await TextReaderSample.ReadTextAsync(ofd.FileName);
            }
        }
    }

    public static class TextReaderSample {
        public static async Task<string> ReadTextAsync(string FileName) {
            var sb = new StringBuilder();

            //非同期でテキストファイルを読み込む
            using var sr = new StreamReader(FileName);
            while (!sr.EndOfStream) {
                var line = await sr.ReadLineAsync();
                sb.AppendLine(line);

            }

            return sb.ToString();

        }
    }
}