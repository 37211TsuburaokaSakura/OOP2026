using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public int Year { get; set; }
        public int Month { get; set; }

        //コンストラクタ
        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
        }

        //5.1.2
        public bool Is21Century => 2001 <= Year && Year <= 2100;


        //5.1.3
        public YearMonth AddoOneMonth(int year,int month) {
            if (Month == 12) {
                //12月の場合
                var GetYear = new YearMonth(year+1,1);
             
                return GetYear;
                
            } else {
                //1～11月の場合
                var GetYears = new YearMonth(year, month + 1);
                return GetYears; 
            }
        }

        //5.1.4
        public override string ToString() => Year+"年"+Month+"月";
        //${Year}年｛Month｝月;
    }
}
