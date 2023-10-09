using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class task_3
        {
            private int End_of_arr = 0;
            private int Future_symbol = 0;
            private int Key = 0;
            private string Input;
            List<char> Copy_array = new List<char>();
            public string Full_alphabet_russian;
            private string Encrypt()
            {
                Console.WriteLine("Ввод:");
                Input = Console.ReadLine();
                Elements();
                for (int i = 0; i < Input.Length; i++)
                {
                    for (int j = 0; j < Full_alphabet_russian.Length; j++)
                    {
                        if (Input[i] == char.ToUpper(Full_alphabet_russian[j]))
                        {
                            Future_symbol = j + Key;
                            //проверка на конец массива
                            if (Future_symbol >= Full_alphabet_russian.Length)
                            {
                                End_of_arr = Future_symbol - Full_alphabet_russian.Length;
                                Copy_array.Add(char.ToUpper(Full_alphabet_russian[End_of_arr]));
                            }
                            else
                                Copy_array.Add(char.ToUpper(Full_alphabet_russian[Future_symbol]));
                        }
                        if (Input[i] == char.ToLower(Full_alphabet_russian[j]))
                        {
                            Future_symbol = j + Key;
                            //проверка на конец массива
                            if (Future_symbol >= Full_alphabet_russian.Length)
                            {
                                End_of_arr = Future_symbol - Full_alphabet_russian.Length;
                                Copy_array.Add(char.ToLower(Full_alphabet_russian[End_of_arr]));
                            }
                            else
                                Copy_array.Add(char.ToLower(Full_alphabet_russian[Future_symbol]));
                        }
                    }
                    //проверка на существование символа в массива(например !)                   
                    if (i != (Copy_array.Count - 1))
                    {
                        Copy_array.Add(Input[i]);
                    }
                }
                Copy_array.ForEach(Console.Write);
                return Input;
            }
            private string Decrypt()
            {
                Console.WriteLine("Ввод:");
                Input = Console.ReadLine();
                Elements();
                for (int i = 0; i < Input.Length; i++)
                {
                    for (int j = 0; j < Full_alphabet_russian.Length; j++)
                    {
                        if (Input[i] == char.ToUpper(Full_alphabet_russian[j]))
                        {
                            Future_symbol = j - Key;
                            //проверка на начало массива
                            if (Future_symbol < 0)
                            {
                                End_of_arr = Future_symbol + Full_alphabet_russian.Length;
                                Copy_array.Add(char.ToUpper(Full_alphabet_russian[End_of_arr]));
                            }
                            else
                                Copy_array.Add(char.ToUpper(Full_alphabet_russian[Future_symbol]));
                        }
                        if (Input[i] == char.ToLower(Full_alphabet_russian[j]))
                        {
                            Future_symbol = j - Key;
                            //проверка на начало массива
                            if (Future_symbol < 0)
                            {
                                End_of_arr = Future_symbol + Full_alphabet_russian.Length;
                                Copy_array.Add(char.ToLower(Full_alphabet_russian[End_of_arr]));
                            }
                            else
                                Copy_array.Add(char.ToLower(Full_alphabet_russian[Future_symbol]));
                        }
                    }
                    //проверка на существование символа в массива(например !)
                    if (i != (Copy_array.Count - 1))
                    {
                        Copy_array.Add(Input[i]);
                    }
                }
                Copy_array.ForEach(Console.Write);
                return Input;
            }
            public string choice_user()
            {
                Console.WriteLine("1.Зашифровать");
                Console.WriteLine("2.Расшифровать");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите ключ:");
                Key = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Encrypt();
                        break;
                    case 2:
                        Decrypt();
                        break;
                    default:
                        Console.WriteLine("Неверный ввод");
                        break;
                }
                return Input;
            }
            private void Elements()
            {
                //Добавление русских букв
                Full_alphabet_russian = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            }
        }

        static void Main(string[] args)
        {
            task_3 task_3 = new task_3();
            task_3.choice_user();
        }
    }
}