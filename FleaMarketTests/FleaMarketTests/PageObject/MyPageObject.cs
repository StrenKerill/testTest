using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class MyPageObject
    {
        private IWebDriver _webDriver;
        public MyPageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
