using System;

namespace ConsoleApp15
{
    class Program

    {
        static void Main(string[] args)
        {
            //här nere deklarerar jag varibler som man använder
            string tal1;
            string tal2;
            string summa;
            int tal12;

            int tal22;
            int summan;
            var keepAlive = true;// sätter keepalive till true
            while (keepAlive)//startar en loop till keepAlive är false 
            {
                try
                {
                    Console.WriteLine("Vilket räknesätt vill du räkna? + - * /"); //fråga skrivs på skärmen vilket räknestäss som du vill räkna
                    string Choice = (Console.ReadLine() ?? "");//läser in ditt val till varibeln Choise
            
                    {

                    }


                    switch (Choice) //startar Switchen
                    {
                        case "+"://tar in om man valt +
                           


                            Console.WriteLine("Skriv tal1");//frågar om första talet du vill räkna
                            tal1 = Console.ReadLine();//hämtar in talet man matat in o läger i varibel tal1
                            tal12 = Convert.ToInt32(tal1);// conventerar tal1 till interger så man kan räkna o läger tal12

                            Console.WriteLine("skriv tal 2");//frågar efter tal 2
                            tal2 = Console.ReadLine();//läser in tal2
                            tal22 = Convert.ToInt32(tal2); //conventerar tal2 till interget och lägger i tal22
                            summan = tal12 + tal22; //räknar ut summan av tal1 och tal 2
                            summa = Convert.ToString(summan); //conventerar summan till en string 
                            Console.WriteLine("Summan är" + " " + summa);//skriver ut summan är och sen summan
                            Console.ReadKey();//gör så konsolen blir öppen till man tryckt på en knapp
                            break;//avslutar detta case

                             case "-"://case - startar om man väljer -
                           
                            Console.WriteLine("Skriv tal1");//ber dig skriva tal1
                            tal1 = Console.ReadLine();//läser in tal1
                            tal12 = Convert.ToInt32(tal1);//conventerar tal1 till interger och lägger i tal12

                            Console.WriteLine("skriv tal 2");
                            tal2 = Console.ReadLine();
                            tal22 = Convert.ToInt32(tal2);
                            summan = tal12 - tal22;
                            summa = Convert.ToString(summan);
                            Console.WriteLine("Differensen är" + " " + summa);
                            Console.ReadKey();
                            break;

                        case "*":

                            Console.WriteLine("Skriv tal1");
                            tal1 = Console.ReadLine();
                            tal12 = Convert.ToInt32(tal1);

                            Console.WriteLine("skriv tal 2");
                            tal2 = Console.ReadLine();
                            tal22 = Convert.ToInt32(tal2);
                            summan = tal12 * tal22;
                            summa = Convert.ToString(summan);
                            Console.WriteLine("Produkten är" + " " + summa);
                            Console.ReadKey();
                            break;

                        case "/":

                            Console.WriteLine("Skriv tal1");
                            tal1 = Console.ReadLine();
                            tal12 = Convert.ToInt32(tal1);

                            Console.WriteLine("skriv tal 2");
                            tal2 = Console.ReadLine();
                            tal22 = Convert.ToInt32(tal2);
                            summan = tal12 / tal22;
                            summa = Convert.ToString(summan);
                            Console.WriteLine("Kvoten är" + " " + summa);
                            Console.ReadKey();
                            break;

                        case "Q":
                            keepAlive = false;// stänger programmet
                            break;

                            
                      



                    }
                }



                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("De var ett felaktigt val!");

                    Console.ResetColor();
                }
               
                
            }
            
                
            }
        }
    }

