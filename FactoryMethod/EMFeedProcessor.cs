using System;
using System.Collections.Generic;

namespace Epam.NetMentoring.FactoryMethod
{
    internal class EMFeedProcessor : IFeedProcessor
    {
        public FeedItem Match(FeedItem feeditem)
        {
            if (AccountDB.Accounts.ContainsKey(feeditem.SourceAccountId))
                return feeditem;
            return new EmFeed();
        }

        public void Save(FeedItem matchedaccount)
        {
            throw new System.NotImplementedException();
        }

        public void SaveErrors(IEnumerable<ValidationError> validationError)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ValidationError> Validate(FeedItem feeditem)
        {
            if (feeditem.SourceAccountId == 0)
                throw new ValidationError();
            return null;
        }
    }
}