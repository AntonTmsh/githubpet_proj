namespace Epam.NetMentoring.FactoryMethod
{
    internal class EMFeedManager : FeedManager
    {
        public override IFeedProcessor GetFeedProcessor()
        {
            return new EMFeedProcessor();
        }
    }
}