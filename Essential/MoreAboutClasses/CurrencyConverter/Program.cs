using System;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double uah = 10;
            double usdToUahRate = 0.035;
            double eurToUahRate = 0.03;
            double rubToUahRate = 2.76;

            Converter todayRates = new Converter(usdToUahRate, eurToUahRate, rubToUahRate);

            double resultUahToUsd = todayRates.UahToUsd(uah);
            Console.WriteLine($"{uah} UAH equals to {resultUahToUsd} in USD");

            double resultUahToEur = todayRates.UahToEur(uah);
            Console.WriteLine($"{uah} UAH equals to {resultUahToEur} in EUR");

            double resultUahToRub = todayRates.UahToRub(uah);
            Console.WriteLine($"{uah} UAH equals to {resultUahToRub} in RUB");

            double usd = 25.5;
            double resultUsdToUah = todayRates.UsdToUah(usd);
            Console.WriteLine($"{usd} USD equals to {resultUsdToUah} in UAH");

            double eur = 15.5;
            double resultEurToUah = todayRates.EurToUah(eur);
            Console.WriteLine($"{eur} EUR equals to {resultEurToUah} in UAH");

            double rub = 12.5;
            double resultRubToUah = todayRates.RubToUah(rub);
            Console.WriteLine($"{rub} RUB equals to {resultRubToUah} in UAH");

            Console.ReadKey();

        }
    }
}
