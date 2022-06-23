using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class OffersAndDealObject
    {
        private IWebDriver _webDriver;

        public OffersAndDealObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
