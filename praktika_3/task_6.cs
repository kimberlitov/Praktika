namespace c_sharp3
{
    internal class Program
    {
        class SQLCommand
        {
            private double Dispersia;
            private double Standard_deviation;
            private double Median;
            private int[] t = new int[20];
            public override int GetHashCode()
            {
                return t.GetHashCode();
            }
            public double M() //генеральная средняя
            {

                Sql_up();
                return t.Average();
            }
            public double D() //исправленная дисперсия
            {
                Dispersia = M();
                return t.Sum(a => (a - Dispersia) * (a - Dispersia)) / (t.Length - 1);
            }
            public double G() //среднеквадратическое отклонение
            {
                Standard_deviation = D();
                return Math.Abs(Math.Sqrt(Standard_deviation * Standard_deviation));
            }
            public double Mediana()
            {

                var sum = t.Sum();
                var accum = 0;
                for (int i = 0; i < t.Length; i++)
                {
                    accum += t[i];
                    if (accum >= sum / 2)
                    {
                        Median = i;
                        return i;
                    }
                }
                return t.Length;
            }
            private void Sql_up()
            {
                Random rand = new Random();
                for (int y = 0; y < 20; y++)
                {
                    t[y] = rand.Next(1, 10);
                }
            }
            public double return_numbers()
            {
                Console.WriteLine(Dispersia);
                Console.WriteLine(Standard_deviation);
                Console.WriteLine(Median);
                return 1;
            }
        }
        static void Main(string[] args)
        {
            SQLCommand cmd = new SQLCommand();
            cmd.M();
            cmd.D();
            cmd.G();
            cmd.Mediana();
            cmd.return_numbers();
            cmd.GetHashCode();
        }
    }
}