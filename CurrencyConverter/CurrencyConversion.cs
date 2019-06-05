using System;
using System.Globalization;

namespace CurrencyConverter
{
    class Currency
    {
        private readonly double[] userMoney;

        public Currency(double[] userMoney)
        {
            this.userMoney = userMoney;
        }

        public double DollarSum() // find the sum of the user entered money 
        {
            double sum = 0;
            for (int i = 0; i < userMoney.Length; i++)
            {
                sum += userMoney[i];
            }
            return sum;
        }

        public string Average()
        {
            return string.Format("{0:0.00}", DollarSum() / userMoney.Length);
        }

        public double DollarMax() // find the maximum 
        {
            double max = Math.Max(Math.Max(userMoney[0], userMoney[1]), userMoney[2]); 
            return max;
        }

        public double DollarMin() // find the minimum of the money entered
        {
            double min = Math.Min(Math.Min(userMoney[0], userMoney[1]), userMoney[2]);
            return min;
        }

        public string USADollar() // format dollar sum
        {
            decimal baseMoneyValue = (decimal)DollarSum();
            return string.Format("{0:C}", baseMoneyValue);
        }

        public string SwedishKrona() // convert and format dollar sum to Krona 
        {
            decimal baseMoneyValue = (decimal)(DollarSum() * 9.45638);
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("se-SE");
            return string.Format(cultureInfo, "{0:C}", baseMoneyValue);
        }
        public string JapaneseYen() // convert dollar sum to Yen
        {
            decimal baseMoneyValue = (decimal)(DollarSum() * 108.285);
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("jp-JP");
            return string.Format(cultureInfo, "{0:C}", baseMoneyValue);
        }
        public string ThaiBaht() // convert dollar sum to Baht
        {
            decimal baseMoneyValue = (decimal)(DollarSum() * 31.3515);
            CultureInfo cultureInfo = CultureInfo.GetCultureInfo("th-TH");
            return string.Format(cultureInfo, "{0:C}", baseMoneyValue);
        }

        public override string ToString()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            return $"Average: {Average()} \nMax: {DollarMax()} \nMin: {DollarMin()} \nUSD: {USADollar()}" +
                $"\nSwedish: {SwedishKrona()} \nJapanese: {JapaneseYen()} \nThai: {ThaiBaht()}";
        }
    }
}
