namespace c_sharp3
{
    internal class Program
    {
        class car
        {
            public string car_name;
            public string n;
            public int speed;
            public int s;
            public car(string n, int s)
            {
                car_name = n;
                speed = s;
            }
            public void Print()
            {
                Console.WriteLine(car_name);
                Console.WriteLine(speed);
            }
        }
        static void Main(string[] args)
        {
            car DeLorean = new car("DeLorean DMC-12", 88);
            car Kia = new car("Kia soul", 100);
            car Toyota = new car("Toyota Supra", 140);
            car Skoda = new car("Skoda Rapid", 120);
            if (Kia.speed > Toyota.speed && Kia.speed > DeLorean.speed && Kia.speed > Skoda.speed)
            {
                Kia.Print();
                Console.WriteLine("Kia won");
            }
            if (DeLorean.speed > Toyota.speed && DeLorean.speed > Kia.speed && DeLorean.speed > Skoda.speed)
            {
                DeLorean.Print();
                Console.WriteLine("DeLorean won");
            }
            if (Toyota.speed > Kia.speed && Toyota.speed > DeLorean.speed && Toyota.speed > Skoda.speed)
            {
                Toyota.Print();
                Console.WriteLine("Toyota won");
            }
            if (Skoda.speed > Toyota.speed && Skoda.speed > DeLorean.speed && Skoda.speed > Kia.speed)
            {
                Skoda.Print();
                Console.WriteLine("Skoda won");
            }
        }
    }
}