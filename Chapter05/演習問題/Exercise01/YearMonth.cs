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
                var GetYear = new YearMonth(year,month-11);
             
                return GetYear;
                
            } else {
                var GetYears = new YearMonth(year, month + 1);
                return GetYears; 
            }
        }
    }
}
