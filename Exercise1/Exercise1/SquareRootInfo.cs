using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class SquareRootInfo
    {
        //constructor
        public SquareRootInfo(double limit)
        {
            this.errorlimit = limit;
        }
        public double errorlimit { get; set; }
        public double number { get; set; }
        public double guess { get; set; }
    }
}


