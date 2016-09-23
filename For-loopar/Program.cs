using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
            */
            // Övning2
            /*
            for (int i = 20; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
            */
            //Övning 3
            /*
            for (int i = 0; i <= 50; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
            */
            //Övning 4
            /*
            Console.WriteLine("Mata in en start:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata ett stop:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Mata in steg:");
            int z = int.Parse(Console.ReadLine());

            for (int i = x; i <= y; i = i + z)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();
            */
            //Övning 5
            /*
            Console.WriteLine("Mata in ett heltal:");
            int x = int.Parse(Console.ReadLine());
            int y = 0;

            for (int i = 0; i <= x; i++)
            {
               
                y += i;

                if (i == x)
                {
                    Console.WriteLine("Summan av tal från 1 till 10: " + y);
                }
                
            }
            Console.ReadKey();
            */
            //Övning 6
            /*
            Console.WriteLine("Mata in ett heltal:");
            int heltal = int.Parse(Console.ReadLine());

            if (heltal > 21)
            {
                for (int i = 1; i < heltal; i++)
                {

                    if (i % 3 == 0 && i % 7 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
            }
            else
            {
                Console.WriteLine("Inga tal machade");
            }
            
            Console.ReadKey();
            */
            //Övning 7
            /*
            Console.WriteLine("Mata in ett heltal:");
            int heltal = int.Parse(Console.ReadLine());


            int z = 0;
            int y = 1;

            Console.Write("Fibbonacci blir: ");
            for (int i = 0; i < heltal; i++)
            {
                int nyttVärde = z;
                z = y;
                y = nyttVärde + y;


                Console.Write(y + " ");
            }

            Console.ReadKey();
            */
            //Övning 8
            /*
            Console.WriteLine("Mata in ett heltal:");
            int heltal = int.Parse(Console.ReadLine());

            for (double i = 0; i < heltal; i = i + 0.1)
            {
                if ( i * i * i >= heltal)
                {
                    Console.WriteLine(Math.Round(i,1));
                    break;
                }

            }
            Console.ReadKey();
            */
            //Övning 9

            /*    if (heltal == 1)
                    {
                        Console.WriteLine("Primtal!");
                    }

                    bool primtal = true;

                    for (int i = 2; i < heltal; i++)
                    {
                        if ( heltal % i == 0)
                        {
                            primtal = false;
                            break;
                        }
                    }

                    if (primtal)
                    {
                        Console.WriteLine("Primtal!");
                    }
                    else
                    {
                        Console.WriteLine("Inte ett primtal");
                    }
                */
            /*
            //Ovning 9 v2.0

        Console.WriteLine("Skriv in ett heltal");

        int heltal = int.Parse(Console.ReadLine());

        if (ÄrPrimtal(heltal))
        {
            Console.WriteLine("Primtal!");
        }
        else
        {
            Console.WriteLine("Inte ett primtal");
        }

        Console.ReadKey();

    }

    public static bool ÄrPrimtal(int heltal)
    {
        if (heltal == 1)
        {
            return true;
        }

        for (int i = 2; i < heltal; i++)
        {
            if (heltal % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    */

            Console.WriteLine("Skriv in ett tal MF:");

            int tal = int.Parse(Console.ReadLine());

            for (int i = 0; i < tal; i++)
            {
                if(tal % i = 0)
                {

                }

            }
        }


    }

}
