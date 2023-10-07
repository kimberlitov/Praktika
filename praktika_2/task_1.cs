namespace c_sharp3
{
    internal class Program
    {
        class quadratic_equation
        {
            //Коэффициэнты
            private double a;
            private double b;
            private double c;
            //корень
            private double x;
            //дискриминант
            private double D;

            public double For_a
            {
                get
                {
                    return a;
                }
                set
                {
                    a = value;
                }
            }
            public double For_b
            {
                get
                {
                    return b;
                }
                set
                {
                    b = value;
                }
            }
            public double For_c
            {
                get
                {
                    return c;
                }
                set
                {
                    c = value;
                }
            }
            public double For_x
            {
                get
                {
                    return x;
                }
                set
                {
                    x = value;
                }
            }
            private double discriminant()
            {
                D = (b * b) - (4 * a * c);
                return D;
            }
            public void CalculateRoots()
            {
                discriminant();
                if (D < 0)
                {
                    Console.WriteLine("Корней нет");
                }
                if (D == 0)
                {
                    x = (-b) / (2 * a);
                    Console.WriteLine(x);
                }
                if (D > 0)
                {
                    x = ((-b) + Math.Sqrt(discriminant())) / (2 * a);
                    Console.WriteLine(x);
                    x = 0;
                    x = ((-b) - Math.Sqrt(discriminant())) / (2 * a);
                    Console.WriteLine(x);
                }
            }
            public quadratic_equation()
            {
                //не меняет результата 
                a = 100;
                b = 100;
                c = 50;
            }
        }

        static void Main(string[] args)
        {
            quadratic_equation q = new quadratic_equation();
            q.For_a = 1;
            q.For_b = 3;
            q.For_c = -4;
            q.CalculateRoots();

        }
    }
}