public class Store
        {

            public static void Main(string[] args)
            {
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Number:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Owner Name:");
                string Ower = Console.ReadLine();
                Console.WriteLine("INPUT Number:");

                int InputMoney = int.Parse(Console.ReadLine());
                Console.WriteLine("***********Shop Information***********");
                Console.WriteLine("Name:{0}", name);
                Console.WriteLine("Number:{0}", number);
                Console.WriteLine("Owner Name:{0}", Ower);
                Console.WriteLine("Registered Value:{0}", InputMoney);
                Console.WriteLine("*********************************");
                Console.WriteLine("Please input money:");
                double input = double.Parse(Console.ReadLine());
                shopping(input);

            }
            public static double[] shopping(double InputMoney)

            {
                double money;
                double percentage;
                double M;
                double D;
                double C;
                double L;
                double XX;
                double X;
                double v;
                double II;
                double I;
                double Lsatang;
                double XXVsatang;


                M = InputMoney / 1000;
                money = InputMoney % 1000;

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

                v = money / 5;
                money = money % 5;

                II = money / 2;
                money = money % 2;

                I = money / 1;

                Lsatang = money / .50;
                money = money % .50;

                XXVsatang = money / .25;
                money = money % .25;






                Console.WriteLine("1000:{0}", Math.Floor(M));
                Console.WriteLine("500:{0}", Math.Floor(D));
                Console.WriteLine("100:{0}", Math.Floor(C));
                Console.WriteLine("50:{0}", Math.Floor(L));
                Console.WriteLine("20:{0}", Math.Floor(XX));
                Console.WriteLine("10:{0}", Math.Floor(X));
                Console.WriteLine("5:{0}", Math.Floor(v));
                Console.WriteLine("2:{0}", Math.Floor(II));
                Console.WriteLine("1:{0}", Math.Floor(I));
                Console.WriteLine("0.5:{0}", Math.Floor(Lsatang));
                Console.WriteLine("0.25:{0}", Math.Floor(XXVsatang));
                double[] Answer ={Math.Floor(M),Math.Floor(D),Math.Floor(C),Math.Floor(L),Math.Floor(XX),
                Math.Floor(X),Math.Floor(v),Math.Floor(II),Math.Floor(I),Math.Floor(Lsatang),Math.Floor(XXVsatang)};
                return Answer;
            }
        }