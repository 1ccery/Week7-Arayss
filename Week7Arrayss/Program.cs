using System;

namespace Week7Arrayss
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab hommiku söögi menüü
            //programm palub kasutajal teha valik
            //program kuvab kasutaja valiku konsoolis

            string[] menu = { "Omlett", "Pannkoogid", "Keeduuna", "NeljaViljaPuder", "SingiVõileib" };
            Console.WriteLine($"Meie menüüs on {menu.Length} valikut");

           // menu[4] = "Juustuõileib";
           // menu[3] = "MannaPuder";

            Console.WriteLine("Täna menüüs :");
            for (int i = 0; i < menu.Length; i++)
            {
                
                if(menu[i] == "Neljaviljapuder")
                {
                    menu[i] = "Kaerapuder";

                }
              
            
                else if(menu[i] == "SingiVõileib")
                {
                    menu[i] = "juustuvõileib";


                }
               Console.WriteLine(menu[i]);

            }

            Console.WriteLine("Tee oma valik (Sisesta number 1 - 5):");
            int userchoice = Convert.ToInt32(Console.ReadLine())-1;
            Console.WriteLine($"Olete valinud {menu[userchoice]}");

            //foreach(string menueelement in menu)
            //{
               
                
              //  Console.WriteLine(menueelement);

            //}

            


        }
    }
}
