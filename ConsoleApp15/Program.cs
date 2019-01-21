using System;

namespace ConsoleApp15
{
    class Program

    {
        static void Main(string[] args)
        {



            {
                string tal1;
                string tal2;
                string summa;
                double tal12;

                double tal22;
                double summan;


                Console.WriteLine("Skriv tal1");//ber dig skriva tal1
                tal1 = Console.ReadLine();//läser in tal1
                tal12 = Convert.ToInt32(tal1);//conventerar tal1 till interger och lägger i tal12

                Console.WriteLine("skriv tal 2");
                tal2 = Console.ReadLine();
                tal22 = Convert.ToInt32(tal2);


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


                                Plus();//skickar ner en till metoden plus
                                break;



                            case "-"://case - startar om man väljer -

                                Minus();//skickar ner till metoden minus
                                break;

                            case "*":

                                Ganger();
                                break;

                            case "/":

                                Delat();
                                break;

                            case "Q":
                                keepAlive = false;
                                break;
                            case "q":
                                keepAlive = false;
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

                private static void Plus()
                {
                    summan = tal12 + tal22;
                    summa = Convert.ToString(summan);
                    Console.WriteLine("Summan är" + " " + summa);
                    Console.ReadKey();
                }
                        {
                    summan = tal12 + tal22;
                    summa = Convert.ToString(summan);
                    Console.WriteLine("Summan är" + " " + summa);
                    Console.ReadKey();
                }
                private static void Minus()
                {
                    summan = tal12 - tal22;
                    summa = Convert.ToString(summan);
                    Console.WriteLine("Differensen är" + " " + summa);
                    Console.ReadKey();
                }
                {
                    summan = tal12 + tal22;
                    summa = Convert.ToString(summan);
                    Console.WriteLine("Summan är" + " " + summa);
                    Console.ReadKey();
                }
                private static void Ganger()
                {
                    summan = tal12 * tal22;
                    summa = Convert.ToString(summan);
                    Console.WriteLine("Produkten är" + " " + summa);
                    Console.ReadKey();
                }
                private static void Delat()
                {
                    summan = tal12 / tal22;
                    summa = Convert.ToString(summan);
                    Console.WriteLine("Differensen är" + " " + summa);
                    Console.ReadKey();
                }
            }
        }
    }
}
        