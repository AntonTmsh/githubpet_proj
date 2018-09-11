using System.Collections.Generic;

namespace Epam.NetMentoring.FactoryMethod
{
    public abstract class FeedManager
    {
        public abstract IFeedProcessor GetFeedProcessor();

        public void Process(IEnumerable<FeedItem> feeditems)
        {
            foreach (var item in feeditems)
            {
                GetFeedProcessor().Validate(item);
                GetFeedProcessor().Save(GetFeedProcessor().Match(item));
            }
        }
    }
}