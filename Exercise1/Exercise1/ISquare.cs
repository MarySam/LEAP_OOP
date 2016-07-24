using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    //Interfaces are defined by what it can take and what it can return.
    //The access modifier is implied as public, cannot use private or add public.
    public interface ISquare
    {
        double Sqrt(double number);
        double ErrorMargin { get; }

    }
}
