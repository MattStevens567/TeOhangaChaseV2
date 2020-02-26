using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeOhangaChaseV2 {
    public class DataClass {
        public string TimeLeft { get; set; }
        public int AmountCorrect { get; set; }

        public DataClass() {
            Console.WriteLine("This is a constuctor");
            AmountCorrect = 0;
            TimeLeft = "";
        }


    }
}
