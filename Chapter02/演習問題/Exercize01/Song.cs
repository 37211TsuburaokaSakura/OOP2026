using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercize01 {
    public class Song {
        //歌のタイトル
        public string Title { get; set; } = string.Empty;

        //アーティスト名
        public string Artist { get; set; } = string.Empty;

        //演奏時間
        public int Length { get; set; }


        //コンストラクタ
        public Song(string title, string artist, int length) {
            Title = title;
            Artist = artist;
            Length = length;
        }

    }



}
