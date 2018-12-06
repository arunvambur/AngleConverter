using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Degree degree = new Degree();
            Radiant radiant = new Radiant();

            var result = degree + radiant;
        }
    }
}
