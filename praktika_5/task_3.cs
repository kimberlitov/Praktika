using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        interface IFilter
        {
            string Execute(string textLine);
        }
        class DigitFilter : IFilter
        {
            public string Execute(string textLine)
            {
                char[] textLine_copy = new char[100];
                char[] numbers = {'�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�','�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�', '�', '�',
                                    '�', '�', '�'};
                for (int i = 0; i < textLine.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (textLine[i] == numbers[j])
                        {
                            textLine_copy[i] = numbers[j];
                        }

                    }
                }
                Console.WriteLine(textLine_copy);
                return textLine_copy.ToString();
            }
        }

        class LetterFilter : IFilter
        {
            public string Execute(string textLine)
            {
                char[] textLine_copy = new char[100];
                char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                for (int i = 0; i < textLine.Length; i++)
                {
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (textLine[i] == numbers[j])
                        {
                            textLine_copy[i] = numbers[j];
                        }
                    }
                }
                Console.WriteLine(textLine_copy);
                return textLine_copy.ToString();
            }
        }
        static void Main(string[] args)
        {
            DigitFilter filter = new DigitFilter();
            filter.Execute("�2");
            LetterFilter letterFilter = new LetterFilter();
            letterFilter.Execute("�2");
        }
    }
}