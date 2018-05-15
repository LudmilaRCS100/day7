using System;



namespace day_8

{

    class Program

    {


        static void Main(string[] args)

        {
            Console.WriteLine("Hello world!");
            
            /*JaunaZvaigzne();
            MasivaPiemers();*/
            Skaitli();


        }

            /*

        {
            int a, b, c, d;
            a = 1;
            b = 5;
            c = 7;
            d = 6;

            int[] masivs = new int[4];
            masivs[0] = 1;
            masivs[1] = 5;
            masivs[2] = 7;
            masivs[3] = 6;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(masivs[i]);

            }

            //Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
        */

        /*static void MasivaPiemers()
        {
                int a, b, c, d;
                a = 1;
                b = 5;
                c = 7;
                d = 6;

                Console.WriteLine(a + "" + b + "" + c + "" + d);

                int[] masivs = new int[100];
                masivs[0] = 1;
                masivs[1] = 5;
                masivs[2] = 7;
                masivs[3] = 6;
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine(masivs[i]);

                }

            //Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
        
        static void JaunaZvaigzne()
        {
            //*
            //**
            //***
            string[] zvaigznites = new string [3];
            zvaigznites[0] = "*";
            zvaigznites[1] = "**";
            zvaigznites[2] = "***";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(zvaigznites[i]);

            }

            Console.WriteLine(zvaigznites[0]);
            Console.WriteLine(zvaigznites[1]);
            Console.WriteLine(zvaigznites[2]);
            Console.ReadLine();
        }
        */
        /*static void Skaitli()
        {
            string[] skaitlis = new string[5];
            int i;
            skaitlis[0] = "*";
            skaitlis[1] = "**";
            skaitlis[2] = "***";
            skaitlis[3] = "****";
            skaitlis[4] = "*****";

            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine(skaitlis[i]);

            }
             Console.WriteLine(skaitlis[0]);
             Console.WriteLine(skaitlis[1]);
             Console.WriteLine(skaitlis[2]);
             Console.WriteLine(skaitlis[3]);
             Console.WriteLine(skaitlis[4]);
             Console.ReadLine();*/

            static void Skaitli()
            {
                string[] ievade = new string[5];
                int[] izvade = new int[5];
                int i;

                for (i = 0; i < 5; i++)
                {
                Console.WriteLine("Ievadiet " + i + " vertibu!");
                ievade [i] = Console.ReadLine();
                izvade[i] = Convert.ToInt16(ievade[i]);
                }
                for (i = 0; i < 5; i++)
                {
                Console.WriteLine(izvade[1]);
            }

        }

        



    }
}


    


            //Funkciju izsaukumi



            //ReizTabula();

            //UzLeju();

            //Zvaigznite();

            //Faktorialis();
            /*int izvele = 1;
            while (izvele != 0)
            {
                Console.WriteLine("1-izvadit reizrekina tabulu");
                Console.WriteLine("2-skaitit no 10 uz leju");
                Console.WriteLine("3-izvadit zvaigznites");
                Console.WriteLine("4-Faktorilis");
                Console.WriteLine("0-iziet");

                string input = Console.ReadLine();
                izvele = Convert.ToInt32(input);

                switch (izvele)
                {
                    case 1:
                        ReizTabula();
                        break;
                    case 2:
                        UzLeju();
                        break;
                    case 3:
                        Zvaigznite();
                        break;
                    case 4:
                        Faktorialis();
                        break;
                    case 0:
                        izvele = 0;
                        break;
                    default:
                        Console.WriteLine("Ievade nav pareiza");
                        break;


                }



            }


            Console.ReadLine();

        }



        static void ReizTabula()

        {

            Console.WriteLine("Ievadiet skaitli: "); //izvade

            string ievade = Console.ReadLine(); //ievade

            //int skaitlis = Convert.ToInt16(ievade);

            double skaitlis = Convert.ToDouble(ievade); //parkonverte uz skaitli ar komatu 



            for (int i = 1; i <= 10; i++) //cikls, cikls bus no 1 lidz, ieskaitot 10

            {

                Console.WriteLine(i + "*" + skaitlis + "=" + i * skaitlis);//izvade

            }

        }



        static void UzLeju()

        {

            for (int i = 10; i >= 1; i--) //cikls, kas skaota no 10 uz leju

            {

                Console.WriteLine(i); // izvada 10, 9, 8, 7,...utt

            }

        }



        static void Zvaigznite()

        {

            //i = i+1

            string zvaigzne = ""; //iveidojam mainigo

            for (int i = 1; i < 4; i++) //cikls, kas skaita no 1 lidz(neieskaitot) 4

            {

                zvaigzne = zvaigzne + "*"; //saglaba veco vertibu + pieliek klat zvaigzniti

                Console.WriteLine(zvaigzne);//izvade

            }

        }



        static void Faktorialis()

        {

            int vertiba = 0; // uztaisa jaunu mainigo, kura vertiba ir 0

            string ievade = Console.ReadLine(); //ievade ar readline

            int robeza = Convert.ToInt16(ievade); //uztaisa jaunu skaitli robeza un pieskir parveidoto simbolu virkni



            for (int i = 1; i <= robeza; i++) // pieskir skaitli robeza ka limitu ciklam

            {

                int OldVertiba = vertiba; //saglaba veco vertibu, lai izvaditu

                vertiba = vertiba + i;//pieskaita veco skaitli iteracijas vertibai

                Console.WriteLine(OldVertiba + "+" + i + "=" + vertiba);//izvade, izvada darbibu

            }

        }

    }

}*/