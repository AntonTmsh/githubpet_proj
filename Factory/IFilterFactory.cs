﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.NetMentoring.Factory
{
    interface IFilterFactory
    {
        IFilter CreateFilter(string filtername);
    }
}
