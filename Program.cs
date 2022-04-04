using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definiranje polja
            Polje NovoPolje = new Polje();
            //Definiranje igraca 1 i igraca 2
            Igrac1 Igrac1= new Igrac1();
            Igrac2 Igrac2= new Igrac2();
            //ucitavanje nula u polje da se polje vidid kada se ispise nije obavezno
            NovoPolje.Start();
            //Definiranje parametra koji je potreban za odredivanje pobjednika
            bool Pobjeda = false;

            //Pocetak igre ucitavanje 9 Parametara onoliko koliko ima ukupniih mijesta
            for (int i = 0; i < 9; i++)
            {

                
                
                if (i % 2 == 0)
                {
                pocetak:
                    //  Ucitavanje kordinata
                    /*Console.WriteLine("Igrac 1: Unesi kordinatu x");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Igrac 1: Unesi kordinatu y");
                    int y = Convert.ToInt32(Console.ReadLine());
                    */
                    int x = Igrac1.IgrajX();
                    int y = Igrac1.IgrajY();
                    //Provjera ispravnosti unosa
                    if (x < 3 && y < 3)
                    {
                        string a = Igrac1.Znak();
                        NovoPolje.UnesiPolje(x,y,a);

                        NovoPolje.IspisPolja();

                    }
                    else
                    {

                        Console.WriteLine("Neispravan unos");
                        goto pocetak;
                    }
                    //Provjera pobjednika
                    Pobjeda = NovoPolje.ProvjeraX();
                    if(Pobjeda == true)
                    {
                        Console.ReadKey();
                        break;
                    }

                }
                else
                {
                pocetak:
                    //Unos
                    /*
                    Console.WriteLine("Igrac 2: Unesi kordinatu x");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Igrac 2: Unesi kordinatu y");
                    int y = Convert.ToInt32(Console.ReadLine());
                    */
                    int x = Igrac2.IgrajX();
                    int y = Igrac2.IgrajY();
                    //Provjera ispravnosti  unosa
                    if (x < 3 && y < 3)
                    {
                        string a = Igrac2.Znak();
                        NovoPolje.UnesiPolje(x, y, a);
                        NovoPolje.IspisPolja();

                    }
                    else
                    {
                        Console.WriteLine("Neispravan unos");
                        goto pocetak;
                    }
                    //Provjera pobjednika
                    Pobjeda = NovoPolje.ProvjeraO();
                    if (Pobjeda == true)
                    {
                        Console.ReadKey();
                        break;
                    }

                }
                
                Console.ReadKey();
            }
           
        }
    }
}
