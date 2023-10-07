namespace c_sharp3
{
    internal class Program
    {
        class task_2
        {
            private int n = 0;
            //след. число
            private int c = 1;
            private bool SetNumber(int number)
            {
                number = Convert.ToInt32(Console.ReadLine());
                n = number;
                for (; ; )
                {
                    if (n != c)
                    {
                        n = 0;
                        c = 1;
                        Console.WriteLine("No");
                        return false;
                    }
                    n++;
                    c++;
                    return true;
                }
            }
            public bool For_n()
            {
                return SetNumber(c);
            }
        }

        static void Main(string[] args)
        {
            task_2 task = new task_2();
            for (; ; )
            {
                task.For_n();
            }
        }
    }
}