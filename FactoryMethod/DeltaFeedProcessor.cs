using System.Collections.Generic;

namespace Epam.NetMentoring.FactoryMethod
{
    internal class DeltaFeedProcessor : IFeedProcessor
    {
        public FeedItem Match(FeedItem feeditem)
        {
            throw new System.NotImplementedException();
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
            throw new System.NotImplementedException();
        }
    }
}