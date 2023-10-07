using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        interface IAnimal
        {
            void Voice();
        }
        class Dog : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Γΰβ!");
            }
        }
        class Cat : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Μÿσ!");
            }
        }
        class Cow : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Μσσσσ!");
            }
        }
        class Fox : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Υευευε!");
            }
        }
        class Owl : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Συ!");
            }
        }
        static void Main(string[] args)
        {
            List<IAnimal> myAnimals = new List<IAnimal>();

            myAnimals.Add(new Dog());
            myAnimals.Add(new Cat());
            myAnimals.Add(new Owl());
            myAnimals.Add(new Fox());
            myAnimals.Add(new Cow());

            foreach (IAnimal animal in myAnimals)
            {
                animal.Voice();
            }

            Console.ReadKey(true);
        }
    }
}