namespace Lb_1_TA
{
    internal class Program
    {
        static void Main()
        {
            // Мова програмування C#
            
            int[] One = new int[2];
            int[] Two = new int[2];
            int[] Three = new int[2];
            int[] Four = new int[2];

            string[] XY = new string[2]; //Декоративний масив для консолі
            XY[0] = "x";
            XY[1] = "y";


            Console.WriteLine("Координати першої точки ");
            for (int i = 0; i < One.Length; i++)
            {
                Console.Write(XY[i] + " ");
                One[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Координати другої точки ");
            for (int i = 0; i < Two.Length; i++)
            {
                Console.Write(XY[i] + " ");
                Two[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Координати третьої точки ");
            for (int i = 0; i < Three.Length; i++)
            {
                Console.Write(XY[i] + " ");
                Three[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Координати четвертої точки ");
            for (int i = 0; i < Two.Length; i++)
            {
                Console.Write(XY[i] + " ");
                Four[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            //Перевірка на співпадіння точок
            if (One[0] == Two[0] && One[1] == Two[1] || One[0] == Three[0] && One[1] == Three[1] || One[0] == Four[0] && One[1] == Four[1]) 
            {
                Console.WriteLine("Error");
                return;
            }
            if (Two[0] == One[0] && Two[1] == One[1] || Two[0] == Three[0] && Two[1] == Three[1] || Two[0] == Four[0] && Two[1] == Four[1])
            {
                Console.WriteLine("Error");
                return;
            }
            if (Three[0] == One[0] && Three[1] == One[1] || Three[0] == Two[0] && Three[1] == Two[1] || Three[0] == Four[0] && Three[1] == Four[1])
            {
                Console.WriteLine("Error");
                return;
            }
            double OneTwo, TwoThree, ThreeFour, FourOne, Perumetr; // проміжні данні для зберігання обчислень
            OneTwo = Calculate(One[0], One[1], Two[0], Two[1]); // Обрахування кожної сторони
            TwoThree = Calculate(Two[0], Two[1], Three[0], Three[1]);
            ThreeFour = Calculate(Three[0], Three[1], Four[0], Four[1]);
            FourOne = Calculate(Four[0], Four[1], One[0], One[1]);
            
            Perumetr = OneTwo + TwoThree + ThreeFour + FourOne; //Периметр
            Console.WriteLine();
            Console.WriteLine("Периметр чотирикутника: " + Perumetr);
            Console.ReadLine();
        }

        static double Calculate(int x1, int y1, int x2, int y2) //Відстань між двома точками
        {
            double Result;
            double xRes, yRes, sum, squr;
            xRes = Math.Pow((x1 - x2), 2);
            yRes = Math.Pow((y1 - y2), 2);
            sum = xRes + yRes;
            squr = Math.Pow(sum, 0.5);
            Result = squr;
            return Result;
        }
    }
}
