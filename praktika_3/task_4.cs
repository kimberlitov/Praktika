using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class MyIntList
        {
            private List<int> numbersList = new List<int>();
            public List<int> NumbersList
            {
                get { return numbersList; }
            }


            public double Average
            {
                get
                {
                    return CalculateAverage();
                }
            }

            public void AddNumber(int number)
            {
                NumbersList.Add(number);
            }

            public void RemoveNumber(int number)
            {
                NumbersList.Remove(number);
            }


            private double CalculateAverage()
            {
                int sum = 0;
                foreach (int number in NumbersList)
                {
                    sum += number;
                }
                return sum / (double)NumbersList.Count;
            }
        }


        static void Main(string[] args)
        {
            MyIntList numbers = new MyIntList();
            numbers.AddNumber(1);
            numbers.AddNumber(2);
            numbers.AddNumber(2);

            Console.WriteLine(numbers.Average);
            Console.ReadKey(true);

        }
    }
}
