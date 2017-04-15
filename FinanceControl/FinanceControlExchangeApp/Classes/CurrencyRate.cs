namespace FinanceControlExchangeLib
{
    public class CurrencyRate
    {
        public string CurrencyStringCode;
        public string CurrencyName;
        public double ExchangeRate;

        public override string ToString()
        {
            return CurrencyStringCode;
        }

        public string GetString()
        {
            return string.Format($"100 {CurrencyName} ({CurrencyStringCode}) = {ExchangeRate}");
        }
    }
}
