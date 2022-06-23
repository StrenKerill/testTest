using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class ProductObject
    {
        private IWebDriver _webDriver;

        public ProductObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
