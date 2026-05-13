
namespace Exercize01 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("***曲の登録***");
            var songs = new List<Song>();


            //ループ
            while (true) {
                //曲名
                Console.Write("曲名：");
                string? title = Console.ReadLine();

                if (title.Equals("end", StringComparison.OrdinalIgnoreCase))
                    break;
                //アーティスト名
                Console.Write("アーティスト名：");
                string? artistname = Console.ReadLine();

                //演奏時間
                Console.Write("演奏時間(秒)：");
                int length = int.Parse(Console.ReadLine());

                //Song インスタンスを作成
                Song song = new Song(title, artistname, length);

                //歌データを入れるリストオブジェクトへ登録
                songs.Add(song);

                Console.WriteLine(); //改行



            }
            PrintSongs(songs);
            /* 2.1.3
            var songs = new Song[] {

                new Song("Let it be", "The Beatles", 243),

                new Song("Bridge Over Troubled Water", "Simon & Garfunkel", 293),

                new Song("Close To You", "Carpenters", 276),

                new Song("Honesty", "Billy Joel", 231),

                new Song("I Will Always Love You", "Whitney Houston", 273),
              

            };
           
            */
        }

        /*
        Mainメソッド内のPrintSongs(songs)をクリックして
        Alt + Enterを押して「メソッドを生成する」を選択すると、
        以下のメソッドが自動的に生成される
        2.1.4
        */
        private static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {

                Console.WriteLine($"{song.Title},{song.ArtistName},{song.Length / 60}:{song.Length % 60}");
            }

        }
    }
}
