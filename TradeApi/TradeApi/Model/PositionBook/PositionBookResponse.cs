namespace TradeApi.Model.PositionBook
{
    public class PositionBookResponseData
    {
        public List<PositionBookResponsePosition> position { get; set; }
    }

    public class PositionBookResponsePosition
    {
        public string dispSym { get; set; }
        public string instrument { get; set; }
        public string baseSym { get; set; }
        public object companyName { get; set; }
        public string prdType { get; set; }
        public string type { get; set; }
        public string ltp { get; set; }
        public string bookedPnl { get; set; }
        public string unRealizedPnl { get; set; }
        public string lotSize { get; set; }
        public string pnlPerc { get; set; }
        public string netPnl { get; set; }
        public string prevPos { get; set; }
        public string prevAvgPrice { get; set; }
        public string currPos { get; set; }
        public string currAvgPrice { get; set; }
        public string netQty { get; set; }
        public string buyQty { get; set; }
        public string sellQty { get; set; }
        public string dayBuyQty { get; set; }
        public string daySellQty { get; set; }
        public string cfBuyQty { get; set; }
        public string cfSellQty { get; set; }
        public string buyAvgPrice { get; set; }
        public string sellAvgPrice { get; set; }
        public string dayBuyAvgPrice { get; set; }
        public string daySellAvgPrice { get; set; }
        public string cfBuyAvgPrice { get; set; }
        public string cfSellAvgPrice { get; set; }
        public string buyAmt { get; set; }
        public string sellAmt { get; set; }
        public string cfBuyAmt { get; set; }
        public string cfSellAmt { get; set; }
        public string avgPrice { get; set; }
        public string undAsset { get; set; }
        public string exc { get; set; }
        public string trSym { get; set; }
        public object isin { get; set; }
        public string isSquareoff { get; set; }
        public string transferable { get; set; }
        public string ordAction { get; set; }
    }

    public class PositionBookResponse
    {
        public string code { get; set; }
        public string message { get; set; }
        public PositionBookResponseData data { get; set; }
        public long timestamp { get; set; }
    }


}
