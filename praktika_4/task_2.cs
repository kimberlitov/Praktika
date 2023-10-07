using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class Package
        {
            private string Description_package { get; set; }
            public double Weight { get; set; }
            public Package(string description_package, double weight)
            {
                Description_package = description_package;
                Weight = weight;
            }
        }

        class Sending_service
        {
            private double Limit_Weight { get; set; }
            public void Send_a_package(Package package)
            {
                if (package.Weight > Limit_Weight)
                {
                    Console.WriteLine("Лимит посылки превышен, отправка отменяется.");
                }
                else Console.WriteLine("Посылка доставляется");
            }
            public Sending_service(double limit_Weight)
            {
                Limit_Weight = limit_Weight;
            }
        }
        static void Main(string[] args)
        {
            Package key_gate = new Package("Ключ для калитки", 0.2);
            Sending_service service = new Sending_service(10);
            service.Send_a_package(key_gate);
        }
    }
}