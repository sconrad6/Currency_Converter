using System;
namespace CurrencyConverter
{
    public class CurrencyTest
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Please enter three dollar amounts, excluding the $ sign.");

            double[] userMoney = new double[3];
            for (int i = 0; i < userMoney.Length; i++)
            {
                userMoney[i] = Convert.ToDouble(Console.ReadLine());
            }
            Currency currency1 = new Currency(userMoney);
            Console.WriteLine(currency1);
        }
    }
}
