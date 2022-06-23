using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class MyLotsObject
    {
        private IWebDriver _webDriver;

        public MyLotsObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
