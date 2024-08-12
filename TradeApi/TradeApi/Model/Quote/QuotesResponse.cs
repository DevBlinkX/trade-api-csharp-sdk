namespace TradeApi.Model.Quote
{
    public class QuotesResponseData
    {
        public List<QuotesResponseQuoteResponse> quoteResponse { get; set; }
    }

    public class QuotesResponseQuoteResponse
    {
        public string exchangeInstrumentID { get; set; }
        public double ltp { get; set; }
        public string exchange { get; set; }
    }

    public class QuotesResponse
    {
        public int code { get; set; }
        public string infoID { get; set; }
        public QuotesResponseData data { get; set; }
        public string timestamp { get; set; }
        public string status { get; set; }
    }
}
