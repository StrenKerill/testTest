using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace FleaMarketTests.PageObject
{
    class EditLotsObject
    {
        private IWebDriver _webDriver;



        public EditLotsObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
