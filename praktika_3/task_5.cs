using System.Linq;
namespace c_sharp3
{
    internal class Program
    {
        class SmsMessage
        {

            public double Limit_price
            {
                get;
                set;
            }
            public int Max_length
            {
                get;
                set;
            }
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
                    if (MessageText.Length > Max_length)
                    {
                        MessageText = MessageText.Substring(0, Max_length);
                        Price = (MessageText.Length - 65) * 0.5 + Price;
                        Console.WriteLine(MessageText);
                        return Price;
                    }
                    Price = (MessageText.Length - 65) * 0.5 + Price;
                }
                Console.WriteLine(MessageText);
                return Price;
            }

        }

        static void Main(string[] args)
        {
            SmsMessage smsMessage = new SmsMessage();
            smsMessage.MessageText = "gggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggggg";

            smsMessage.Limit_price = 0.9;
            smsMessage.Max_length = 200;
            smsMessage.Price = 5.9;



            smsMessage.price_count();
        }
    }
}