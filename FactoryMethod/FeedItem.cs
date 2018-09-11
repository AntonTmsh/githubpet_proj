namespace Epam.NetMentoring.FactoryMethod
{
    public class FeedItem
    {
        public int StagingId;
        public string SourceTradeRef;
        public int CounterpartyId;
        public int PrincipalId;
        public string ValuationDate;
        public int CurrentPrice;
        public int SourceAccountId;
    }
    public class DeltaOneFeed : FeedItem
    {
        public int Isin;
        public string MaturityDate;
    }

    public class EmFeed : FeedItem
    {
        public string Sedol;
        public int AssetValue;
    }
}