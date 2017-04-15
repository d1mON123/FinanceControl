using System.Collections.Generic;
using System.Xml.Serialization;

namespace FinanceControlExchangeLib
{
    public abstract class AbstractCurrencyRates
    {
        public class chapter
        {
            [XmlElement("item")]
            public item[] ValuteList;
        }

        public class item
        {
            [XmlElementAttribute("char3")]
            public string ValuteStringCode;

            [XmlElementAttribute("name")]
            public string ValuteName;

            [XmlElementAttribute("rate")]
            public string ExchangeRate;
        }

        public abstract List<CurrencyRate> GetExchangeRates();
    }
}
