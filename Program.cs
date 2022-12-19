using System;

namespace Shop_class
{
    public class Shop
    {
         static void Main(string[] args)
        {
            Console.WriteLine("input Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("input Number:");
            int Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Input Owner Name:");
            string Owner= Console.ReadLine();
            Console.WriteLine("INPUT Money:");
            Console.WriteLine("**********Shop Information**********");
            Console.WriteLine("Name:{0}", Name);
            Console.WriteLine("Number:{0}", Number);
            Console.WriteLine("Owner Name:{0}", Owner);
            double input = double.Parse(Console.ReadLine());
             Console.WriteLine("Registered Value:{0}", input);
            double money;
            double percen;
            double M;
            double D;
            double C;
            double L;
            double XX;
            double X;
            double V;
            double II;
            double I;
            double Lsatang;
            double XXVsatang;


            M = input / 1000;
            money = input % 1000;

            D = money / 500;
            money = money % 500;

            C = money / 100;
            money = money % 100;

            L = money / 50;
            money = money % 50;

            XX = money / 20;
            money = money % 20;

            X = money / 10;
            money = money % 10;

            V = money / 5;
            money = money % 5;

            II = money / 2;
            money = money % 2;

            I = money / 1;

            
            Lsatang = money / .50;
            money = money % .50;

            XXVsatang = money / .25;
            money = money % .25;





            Console.WriteLine("****************************");            
            Console.WriteLine("M:{0}", Math.Floor(M));
            Console.WriteLine("D:{0}", Math.Floor(D));
            Console.WriteLine("C:{0}", Math.Floor(C));
            Console.WriteLine("L:{0}", Math.Floor(L));
            Console.WriteLine("XX:{0}", Math.Floor(XX));
            Console.WriteLine("X:{0}", Math.Floor(X));
            Console.WriteLine("V:{0}", Math.Floor(V));
            Console.WriteLine("II:{0}", Math.Floor(II));
            Console.WriteLine("I:{0}", Math.Floor(I));
            Console.WriteLine("Lsatang:{0}", Math.Floor(Lsatang));
            Console.WriteLine("XXVsatang:{0}", Math.Floor(XXVsatang));
        }
}   }