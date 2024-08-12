namespace TradeApi.Model.Quote
{

    public class QuoteBodyData
    {
        public List<QuoteBodyInstrument> instruments { get; set; }
    }

    public class QuoteBodyInstrument
    {
        public string exchange { get; set; }
        public string exchangeInstrumentID { get; set; }
    }

    public class QuoteBody
    {
        public QuoteBodyData data { get; set; }
    }




}
