namespace Epam.NetMentoring.FactoryMethod
{
    internal class DeltaOneFeedManager : FeedManager
    {
        public override IFeedProcessor GetFeedProcessor()
        {
            return new DeltaFeedProcessor();
        }
    }
}