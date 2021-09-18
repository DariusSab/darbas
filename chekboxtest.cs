using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciadalis.Test
{
    public class chekboxtest
    {
        [Test]

        public static void bestpricelamp()
        {
            IWebDriver chrome = new ChromeDriver();
            chrome.Url = "https://www.ikea.lt/lt";
            IWebElement popup = chrome.FindElement(By.CssSelector("#sidenavWrapper > header > nav > div > button"));
            popup.Click();
            IWebElement bestprices = chrome.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li:nth-child(4) > a"));
            bestprices.Click();
            IWebElement firstadd = chrome.FindElement(By.Id("familyitems"));
            firstadd.Click();
            IWebElement biglamp = chrome.FindElement(By.CssSelector("#contentWrapper > div.container-fluid.px-0 > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(3) > div > div.card-header > a > div.productImg > img"));
            biglamp.Click();
            chrome.Quit();
        }
    }
}
