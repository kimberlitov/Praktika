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
                char[] numbers = {'À', 'Á', 'Â', 'Ã', 'Ä',
                                    'Å', '¨', 'Æ', 'Ç', 'È',
                                    'É', 'Ê', 'Ë', 'Ì', 'Í',
                                    'Î', 'Ï', 'Ð', 'Ñ', 'Ò',
                                    'Ó', 'Ô', 'Õ', 'Ö', '×',
                                    'Ø', 'Ù', 'Ú', 'Û', 'Ü',
                                    'Ý', 'Þ', 'ß','à', 'á', 'â', 'ã', 'ä',
                                    'å', '¸', 'æ', 'ç', 'è',
                                    'é', 'ê', 'ë', 'ì', 'í',
                                    'î', 'ï', 'ð', 'ñ', 'ò',
                                    'ó', 'ô', 'õ', 'ö', '÷',
                                    'ø', 'ù', 'ú', 'û', 'ü',
                                    'ý', 'þ', 'ÿ'};
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
            filter.Execute("Ï2");
            LetterFilter letterFilter = new LetterFilter();
            letterFilter.Execute("Ï2");
        }
    }
}