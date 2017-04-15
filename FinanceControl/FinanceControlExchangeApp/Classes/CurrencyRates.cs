using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;

namespace FinanceControlExchangeLib
{
    public class CurrencyRates : AbstractCurrencyRates
    {
        public override List<CurrencyRate> GetExchangeRates()
        {
            var xs = new XmlSerializer(typeof(chapter));
            XmlReader xr = new XmlTextReader(@"http://bank-ua.com/export/currrate.xml");
            return ((chapter) xs.Deserialize(xr)).ValuteList.Select(valute => new CurrencyRate()
            {
                CurrencyStringCode = valute.ValuteStringCode, CurrencyName = valute.ValuteName, ExchangeRate = Convert.ToDouble(valute.ExchangeRate.Replace('.', ','))
            }).ToList();
        }
    }
}
