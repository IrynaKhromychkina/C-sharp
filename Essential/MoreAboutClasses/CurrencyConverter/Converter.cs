
namespace CurrencyConverter
{
    class Converter
    {
        private double usdToUahRate;
        private double eurToUahRate;
        private double rubToUahRate;

        public Converter(double usdToUahRate, double eurToUahRate, double rubToUahRate)
        {
            this.usdToUahRate = usdToUahRate;
            this.eurToUahRate = eurToUahRate;
            this.rubToUahRate = rubToUahRate;
        }

        public double UahToUsd(double uah) => uah * usdToUahRate;

        public double UahToEur(double uah) => uah * eurToUahRate;

        public double UahToRub(double uah) => uah * rubToUahRate;

        public double UsdToUah(double usd) => usd * (1 / usdToUahRate);

        public double EurToUah(double eur) => eur * (1 / eurToUahRate);

        public double RubToUah(double rub) => rub * (1 / rubToUahRate);
    }
}
