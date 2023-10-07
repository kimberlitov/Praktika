using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class orc
        {
            public int Number_of_gold { get; private set; }
            private int count;
            public void Create_ork()
            {
                count = count + 1;
                if (count > 5)
                {
                    Number_of_gold = Number_of_gold - 2;
                }
                else Number_of_gold = Number_of_gold + 2;
            }
        }
        static void Main(string[] args)
        {
            orc orcs = new orc();
            orcs.Create_ork();
            orcs.Create_ork();
            orcs.Create_ork();
            orcs.Create_ork();
            orcs.Create_ork();
            orcs.Create_ork();
        }
    }
}