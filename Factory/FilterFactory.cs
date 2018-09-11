using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.NetMentoring.Factory
{
    class FilterFactory : IFilterFactory
    {
        public virtual IFilter CreateFilter(string filtername)
        {
            if (filtername == "BOFA")
            { return new BOFA_Filter(); }
            else if (filtername == "Connacord")
            { return new Connacord_Filter(); }
            else if (filtername == "Barclays")
            { return new Barclays_Filter(); }
            return new Default_Filter();
        }
    }
}
