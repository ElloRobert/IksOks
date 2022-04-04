using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IksOks
{
    class Polje
    {
       public string[,] tablica = new string[3,3];




        public virtual void UnesiPolje(int x, int y, string a)
        {
            if(tablica[x, y] == "0")
            {
                tablica[x, y] = a;
            }
            else
            {
                Console.WriteLine("Polje je vec popunjeno");
                return ;
            }
            

        }

        //Napuni polje nulama da se lijepo vidi 
        public void Start()
        {
            //Napuniti tablicu za pocetak
            for (int i = 0; i < 3; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    tablica[(int)i,j] = "0" ;
                }
                

            }
        }
        //Ispisati tablicu
        public void IspisPolja()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t",tablica[i,j]);
                }
                Console.WriteLine("\n");
                
            }
        }

        //Provjeriti pobjednika za igraca 1
        public bool ProvjeraX()
        {
            bool pobjeda = false;

            //Vodoravno
            if (tablica[0, 0] == "X" && tablica[0, 1] == "X" && tablica[0, 2] == "X")
            {
                pobjeda = true;
                goto kraj;
            }
            else
            { pobjeda = false; }

            if (tablica[1, 0] == "X" && tablica[1, 1] == "X" && tablica[1, 2] == "X")
            {
                pobjeda = true;
                goto kraj;
            }
            else
            { pobjeda = false; }

            if (tablica[2, 0] == "X" && tablica[2, 1] == "X" && tablica[2, 2] == "X")
            {
                pobjeda = true;
                goto kraj;
            }
            else { pobjeda = false; }



            //Uspravno
            if (tablica[0, 0] == "X" && tablica[1, 0] == "X" && tablica[2, 0] == "X")
            {
                pobjeda = true;
                goto kraj;
            }
            else { pobjeda = false; }


            if (tablica[0, 1] == "X" && tablica[1, 1] == "X" && tablica[2, 1] == "X")
            {
                pobjeda = true;
                goto kraj;
            }
            else { pobjeda = false; }


            if (tablica[0, 2] == "X" && tablica[1, 2] == "X" && tablica[2, 2] == "X")
            {
                pobjeda = true;
                goto kraj;
            }
            else { pobjeda = false; }




            //Dijagonale

            if (tablica[0, 0] == "X" && tablica[1, 1] == "X" && tablica[2, 2] == "X")
            {
                pobjeda = true;
            }
            else { pobjeda = false; }



            if (tablica[2, 0] == "X" && tablica[1, 1] == "X" && tablica[0, 2] == "X")
            {
                pobjeda = true;
            }
            else { pobjeda = false; }

        //Odluka o pobijedi
        kraj:
            if (pobjeda == true)
            {
                Console.WriteLine(" Pobjednik je igrac 1 ");
            }
            else Console.WriteLine("Jos nemamo pobjednika");

            return pobjeda;

        }

        //Provjera pobjednika za igraca 2
        public bool ProvjeraO()
        {
            
                bool pobjeda = false;

                //Vodoravno
                if (tablica[0, 0] == "O" && tablica[0, 1] == "O" && tablica[0, 2] == "O")
                {
                    pobjeda = true;
                    goto kraj;
                }
                else
                { pobjeda = false; }

                if (tablica[1, 0] == "O" && tablica[1, 1] == "O" && tablica[1, 2] == "O")
                {
                    pobjeda = true;
                    goto kraj;
                }
                else
                { pobjeda = false; }

                if (tablica[2, 0] == "O" && tablica[2, 1] == "O" && tablica[2, 2] == "O")
                {
                    pobjeda = true;
                    goto kraj;
                }
                else { pobjeda = false; }



                //Uspravno
                if (tablica[0, 0] == "O" && tablica[1, 0] == "O" && tablica[2, 0] == "O")
                {
                    pobjeda = true;
                    goto kraj;
                }
                else { pobjeda = false; }


                if (tablica[0, 1] == "O" && tablica[1, 1] == "O" && tablica[2, 1] == "O")
                {
                    pobjeda = true;
                    goto kraj;
                }
                else { pobjeda = false; }


                if (tablica[0, 2] == "O" && tablica[1, 2] == "O" && tablica[2, 2] == "O")
                {
                    pobjeda = true;
                    goto kraj;
                }
                else { pobjeda = false; }




                //Dijagonale

                if (tablica[0, 0] == "O" && tablica[1, 1] == "O" && tablica[2, 2] == "O")
                {
                    pobjeda = true;
                    goto kraj;
                }
                else { pobjeda = false; }



                if (tablica[2, 0] == "O" && tablica[1, 1] == "O" && tablica[0, 2] == "O")
                {
                    pobjeda = true;
                }
                else { pobjeda = false; }

            //Odluka o pobijedi
            kraj:
                if (pobjeda == true)
                {
                    Console.WriteLine("Pobjednik je igrac 2");
                }
                else Console.WriteLine("Jos nemamo pobjednika");

                return pobjeda;

            }
        
        }
        



    }

