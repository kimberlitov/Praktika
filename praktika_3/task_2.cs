using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class SmsMessage
        {
            public double Price
            {
                get;
                set;
            }
            public string MessageText
            {
                get;
                set;
            }
            public double price_count()
            {
                if (MessageText.Length <= 65)
                {
                    Price = 1.5;
                }
                else
                {
                    if (MessageText.Length > 250)
                    {
                        MessageText = MessageText.Substring(0, 250);
                        Price = (MessageText.Length - 65) * 0.5 + 1.5;
                        Console.WriteLine(MessageText);
                        return Price;
                    }
                    Price = (MessageText.Length - 65) * 0.5 + 1.5;
                }
                Console.WriteLine(MessageText);
                return Price;
            }

        }

        static void Main(string[] args)
        {
            SmsMessage smsMessage = new SmsMessage();
            smsMessage.MessageText = "gggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg";
            smsMessage.price_count();
        }
    }
}