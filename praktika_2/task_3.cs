using System.Text;
using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class task_3
        {
            private int g = 0;
            private int g1 = 0;
            private int i = 0;
            private string s;
            private char[] nums_english = new char[52];
            private char[] nums2_english = new char[118];
            private char[] combined = new char[85];
            private string Encrypt()
            {

                Console.WriteLine("Ввод:");
                s = Console.ReadLine();
                ascii_elements();
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < combined.Length; j++)
                    {
                        //Поиск необходимой буквы
                        if (s[i] == combined[j])
                        {
                            j = j + 3;
                            g1 = (combined.Length + j) % combined.Length;
                            if (j >= combined.Length || g1 >= (combined.Length / 2))
                            {
                                g1 = ((combined.Length / 2) + j) % (combined.Length / 2);
                                g = (combined.Length + j) % combined.Length;
                                if (Char.IsLower(s[i]))
                                {
                                    nums2_english[i] = Char.ToLowerInvariant(combined[g]);
                                    Console.Write(nums2_english[i]);
                                    break;
                                }
                                nums2_english[i] = combined[g1];
                                Console.Write(nums2_english[i]);
                                break;
                            }

                            nums2_english[i] = combined[j];
                            Console.Write(nums2_english[i]);
                            break;
                        }
                        if (j == combined.Length - 1)
                        {
                            nums2_english[i] = s[i];
                            Console.Write(nums2_english[i]);
                        }
                    }

                }
                return s;
            }
            private string Decrypt()
            {
                Console.WriteLine("Ввод:");
                s = Console.ReadLine();
                ascii_elements();
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < combined.Length; j++)
                    {
                        if (s[i] == combined[j])
                        {
                            j = j - 3;
                            g1 = (combined.Length + j) % combined.Length;
                            if (j <= combined.Length || g1 <= (combined.Length / 2))
                            {
                                g1 = ((combined.Length / 2) + j) % (combined.Length / 2);
                                g = (combined.Length + j) % combined.Length;
                                if (Char.IsLower(s[i]))
                                {
                                    nums2_english[i] = Char.ToLowerInvariant(combined[g]);
                                    Console.Write(nums2_english[i]);
                                    break;
                                }
                                nums2_english[i] = combined[g1];
                                Console.Write(nums2_english[i]);
                                break;
                            }
                            nums2_english[i] = combined[j];
                            Console.Write(nums2_english[i]);
                            break;
                        }
                        if (j == combined.Length - 1)
                        {
                            nums2_english[i] = s[i];
                            Console.Write(nums2_english[i]);
                        }

                    }
                }
                return s;
            }
            public string choice_user()
            {

                Console.WriteLine("1.Зашифровать");
                Console.WriteLine("2.Расшифровать");
                int choice = Convert.ToInt32(Console.ReadLine());
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
                return s;
            }
            private char[] ascii_elements()
            {
                for (int i = 65; i < 91; i++)
                {
                    //Взятие элементов из таблицы ascii
                    nums_english[g] = (char)i;
                    g++;
                }
                for (int i = 97; i < 123; i++)
                {
                    //Взятие элементов из таблицы ascii
                    nums_english[g] = (char)i;
                    g++;
                }
                char[] alphabet = { 'А', 'Б', 'В', 'Г', 'Д',
                                    'Е', 'Ё', 'Ж', 'З', 'И',
                                    'Й', 'К', 'Л', 'М', 'Н',
                                    'О', 'П', 'Р', 'С', 'Т',
                                    'У', 'Ф', 'Х', 'Ц', 'Ч',
                                    'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
                                    'Э', 'Ю', 'Я','а', 'б', 'в', 'г', 'д',
                                    'е', 'ё', 'ж', 'з', 'и',
                                    'й', 'к', 'л', 'м', 'н',
                                    'о', 'п', 'р', 'с', 'т',
                                    'у', 'ф', 'х', 'ц', 'ч',
                                    'ш', 'щ', 'ъ', 'ы', 'ь',
                                    'э', 'ю', 'я'};
                combined = nums_english.Concat(alphabet).ToArray();
                return combined;
            }
        }

        static void Main(string[] args)
        {
            task_3 task_3 = new task_3();
            task_3.choice_user();
        }
    }
}