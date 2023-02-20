using System;

class program
{
    static void Main(string[] args)
    {
        
        double bill;
        bool pravda = true;

        do
        {
            Console.WriteLine("Vítej v naší restuaraci.\nPolévka je Hrášková\nDnes máme takové menu:\n1 - Svíčková s knedlíkem (135,-Kč)\n2 - Kuřecí rizoto (140,-Kč)\n3 - Rajská omáčka s těstovinami (150,-Kč)\n\nJaký je tvůj výběr?");
            int vyber = Convert.ToInt32(Console.ReadLine());
            switch (vyber)
            {
                case 1:
                    bill =+135;
                    Console.WriteLine("Výborná volba.\nCo si dáte k pití?\n1 - Kofola (30,-Kč)\n2 - Pivo (25,-Kč)\n3 - Voda (20,-Kč)\n");
                    int vyberpiti = Convert.ToInt32(Console.ReadLine());
                    switch (vyberpiti)
                    {
                        case 1:
                            bill =bill+30;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka = ((bill / 100) * dysko) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka);
                            string znovu = Console.ReadLine();
                            if (znovu == "ano")
                            {
                                bill = 0;
                                pravda=true;
                            }
                            else { pravda = false;}
                            break;
                        case 2:
                            bill =bill+25;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko1 = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka1 = ((bill / 100) * dysko1) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka1);
                            string znovu1 = Console.ReadLine();
                            if (znovu1 == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        case 3:
                            bill =bill+20;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko2 = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka2 = ((bill / 100) * dysko2) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka2);
                            string znovu2 = Console.ReadLine();
                            if (znovu2 == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        default:
                            Console.WriteLine("\nAsi jsi chyboval ve výběru. Zkus si objednat odznova.\n\n");
                            pravda = true;
                            break;
                    }break;
                case 2:
                    bill =+140;
                    Console.WriteLine("Výborná volba.\nCo si dáte k pití?\n1 - Kofola (30,-Kč)\n2 - Pivo (25,-Kč)\n3 - Voda (20,-Kč)\n");
                    int vyberpiti1 = Convert.ToInt32(Console.ReadLine());
                    switch (vyberpiti1)
                    {
                        case 1:
                            bill = bill +30;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka = ((bill / 100) * dysko) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka);
                            string znovu = Console.ReadLine();
                            if (znovu == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        case 2:
                            bill = bill+25;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko1 = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka1 = ((bill / 100) * dysko1) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka1);
                            string znovu1 = Console.ReadLine();
                            if (znovu1 == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        case 3:
                            bill = bill+20;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko2 = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka2 = ((bill / 100) * dysko2) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka2);
                            string znovu2 = Console.ReadLine();
                            if (znovu2 == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        default:
                            Console.WriteLine("\nAsi jsi chyboval ve výběru. Zkus si objednat odznova.\n\n");
                            pravda = true;
                            break;

                    }
                    break;
                case 3:
                    bill =+150;
                    Console.WriteLine("Výborná volba.\nCo si dáte k pití?\n1 - Kofola (30,-Kč)\n2 - Pivo (25,-Kč)\n3 - Voda (20,-Kč)\n");
                    int vyberpiti2 = Convert.ToInt32(Console.ReadLine());
                    switch (vyberpiti2)
                    {
                        case 1:
                            bill =bill+30;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka = ((bill / 100) * dysko) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka);
                            string znovu = Console.ReadLine();
                            if (znovu == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        case 2:
                            bill =bill+25;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko1 = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka1 = ((bill / 100) * dysko1) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka1);
                            string znovu1 = Console.ReadLine();
                            if (znovu1 == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        case 3:
                            bill =bill+20;
                            Console.WriteLine("Skvělá kombinace.");
                            Console.WriteLine("A co dýško? \nNapiš kolik procent jsi schopný dát.");
                            double dysko2 = Convert.ToDouble(Console.ReadLine());
                            double konecnacastka2 = ((bill / 100) * dysko2) + bill;
                            Console.WriteLine("\nVaše cena bude {0},-Kč\n\nChce si objednat někdo další? (ano/ne)", konecnacastka2);
                            string znovu2 = Console.ReadLine();
                            if (znovu2 == "ano")
                            {
                                bill = 0;
                                pravda = true;
                            }
                            else { pravda = false; }
                            break;
                        default:
                            Console.WriteLine("\nAsi jsi chyboval ve výběru. Zkus si objednat odznova.\n\n");
                            pravda = true;
                            break;

                    }
                    break;
                default:
                    Console.WriteLine("\nAsi jsi chyboval ve výběru. Zkus si objednat odznova.\n\n");
                    pravda = true;
                    break;
            }

        } while (pravda);
    }
}