using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class Transport_vehicle
        {
            public string Name
            {
                get;
                set;
            }
            public double Max_speed
            {
                get;
                set;
            }
        }
        class Politeh_mashina : Transport_vehicle
        {
            public void Bad_music()
            {
                //�� � �����, � �� �����
                if (Name == "MORGENSHTERN - ARISTOCRAT")
                {
                    Console.WriteLine("bad music");
                }
                else { Console.WriteLine("������� ����"); }
            }
        }
        class Plane : Transport_vehicle
        {
            public void pollinate_the_field()
            {
                switch (Name)
                {
                    case "����":
                        Console.WriteLine("����� ��!");
                        break;
                    default:
                        Console.WriteLine("�� ������������� �����");
                        break;
                }
            }
        }
        class Concrete_Mixer : Transport_vehicle
        {
            public void mix_concrete()
            {
                if (Max_speed <= 1)
                {
                    Console.WriteLine("����� �� ��������� � �������");
                }
                else { Console.WriteLine("������������"); }
            }
        }
        static void Main(string[] args)
        {
            Politeh_mashina politeh = new Politeh_mashina();
            politeh.Name = "MORGENSHTERN - ARISTOCRAT";
            politeh.Bad_music();
            Plane plane = new Plane();
            plane.Name = "����";
            plane.pollinate_the_field();
            Concrete_Mixer concrete_Mixer = new Concrete_Mixer();
            concrete_Mixer.Max_speed = 0.8;
            concrete_Mixer.mix_concrete();
        }
    }
}