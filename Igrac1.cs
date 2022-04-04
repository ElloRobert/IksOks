using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOks
{
     class Igrac1:Polje
    {
       
        //Znak 
        public string Znak()
        {
            return "X";
        }

        //Ucitaj X
       public int IgrajX()
        {
            Console.WriteLine("Igrac 1: Unesi kordinatu x");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        //Ucitaj Y
        public int IgrajY()
        {
            Console.WriteLine("Igrac 1: Unesi kordinatu y");
            int y = Convert.ToInt32(Console.ReadLine());
            return y;
        }

    }
}
