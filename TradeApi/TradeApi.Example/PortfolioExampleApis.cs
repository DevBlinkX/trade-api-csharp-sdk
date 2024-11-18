using TradeApi.Api;
using TradeApi.Model.ConvertPosition;
using TradeApi.Model.GetOHLC;
using TradeApi.Model.HistoricalCandleData;
using TradeApi.Model.IntradayCandleData;
using TradeApi.Model.Quote;
using TradeApi.Model.Report;

namespace TradeApi.Example
{
    internal class PortfolioExampleApis
    {

        public async Task convertPosition()
        {
            ConvertPositionBody body = new ConvertPositionBody()

            {
                Type = "DAY1",
                OrdAction = "Sell",
                ToPrdType = "CNC",
                PrdType = "NRML",
                Qty = 5,
                Exc = "NSE",
                Instrument = "STK",
                Symbol = "IDFC-EQ",
                LotSize = 1,
                ExcToken = "11957"


            };

            ConvertPositionResponse response = await PortfolioApis.ConvertPositionAsync(body);
            Console.WriteLine("Message received: " + response);

        }
        public async Task report()
        {
            ReportBody body = new ReportBody()

            {
                Data = new ReportBodyData()
                {
                    
                    ToDate = "",
                    Days = ""
                }
            };


           

            ReportResponse response = await PortfolioApis.ReportAsync(body);
            Console.WriteLine("Message received: " + response.ToString());

        }
        public async Task getOhlc()
        {

            GetOHLCBody body = new GetOHLCBody()
            {
                Data = new GetOHLCBodyData()
                {
                    Instruments = new List<GetOHLCBodyInstrument>()
        {
            new GetOHLCBodyInstrument()
            {
                Exchange = "NSE",
                ExchangeInstrumentID = "6364"
            }
        }
                }
            };



            GetOHLCResponse response = await MarketDataApis.GetOHLCAsync(body);
            Console.WriteLine("Message received: " + response.ToString());

        }

        public async Task intraday()
        {

            IntradayCandleDataBody body = new IntradayCandleDataBody()
            {
                Data = new IntradayCandleDataBodyData()
                {
                    ExchangeInstrumentID = "22",
                    Exchange = "NSE",
                    StartTime = "Mar 14 2024 150000",
                    EndTime = "Mar 14 2024 161500"
                }
            };
            IntradayCandleDataResponse response = await MarketDataApis.IntradayCandleDataAsync(body);
            Console.WriteLine("Message received: " + response.ToString());
        }

        public async Task historical()
        {
            HistoricalCandleDataResponse response = await MarketDataApis.HistoricalCandleDataAsync("","","","","","","");
            Console.WriteLine("Message received: " + response.ToString());
        }

        public async Task quote()
        {
            QuoteBody body = new QuoteBody()
            {
                data = new QuoteBodyData()
                {
                    instruments = new List<QuoteBodyInstrument>()
        {
            new QuoteBodyInstrument()
            {
                exchange = "NSE",
                exchangeInstrumentID = "22"
            }
        }
                }
            };

            QuotesResponse response = await MarketDataApis.QuotesAsync(body);
            Console.WriteLine("Message received: " + response.ToString());

        }
    }
}
