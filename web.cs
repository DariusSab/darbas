using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace darbas
{
    public class webikea
    {

        private static IWebDriver chrome;

        public static IWebDriver Driver { get; private set; }

        [OneTimesetup]

        public static void onetime()
        {
            chrome = new ChromeDriver();
            chrome.Url = "https://www.ikea.lt/lt";
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome == ResultState.Success)
            {
                Screenshot.TakeScreenshot(chrome);
            }
        }

        [OneTimeTearDown]

        public static void onetimeteardown()
        {
            chrome.Quit();
        }


        [Test]

        public static void bestpricelamp()
        {

            IWebElement popup = chrome.FindElement(By.CssSelector("#sidenavWrapper > header > nav > div > button"));
            popup.Click();
            IWebElement bestprices = chrome.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li:nth-child(4) > a"));
            bestprices.Click();
            IWebElement firstadd = chrome.FindElement(By.Id("familyitems"));
            firstadd.Click();
            IWebElement biglamp = chrome.FindElement(By.CssSelector("#contentWrapper > div.container-fluid.px-0 > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(3) > div > div.card-header > a > div.productImg > img"));
            biglamp.Click();

            string ResultText = chrome.FindElement(By.CssSelector("#contentWrapper > div > div > div > div.row.item_detail_information > div.col-12.col-sm-12.col-md-5.col-lg-5.col-xl-4 > div > div.itemInfo > div.itemPriceBox > div > div > p > span")).Text;
            Assert.AreEqual("34.99", ResultText, "Text is wrong");





        }

        [Test]
        [Obsolete]
        public static void IKEAstalvirsis()
        {

            IWebElement popups = chrome.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAcceptWrapper"));
            popups.Click();
            Thread.Sleep(5000);
            IWebElement popup = chrome.FindElement(By.CssSelector("#sidenavWrapper > header > nav > div > button"));
            popup.Click();
            IWebElement banduplanavimas = chrome.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li:nth-child(6) > a"));
            banduplanavimas.Click();
            IWebElement stalvirsioskaiciuokle = chrome.FindElement(By.CssSelector("#contentWrapper > div.container.customPages > div.container.px-0 > div > div:nth-child(5) > div > h5 > a > span"));
            stalvirsioskaiciuokle.Click();
            // nevisa suveikia laukimas 
            //  Thread.Sleep(5000);
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            wait.Until(ExpectedConditions.ElementExists(By.CssSelector("#createNewButton > div")));
            IWebElement kurtinauja = chrome.FindElement(By.CssSelector("#createNewButton > div"));
            kurtinauja.Click();
            IWebElement pavirsius = chrome.FindElement(By.Id("option-material-wood-image-normal"));
            pavirsius.Click();
            IWebElement dizainas = chrome.FindElement(By.Id("option-expression-karlbyoakveneer-image-normal"));
            dizainas.Click();
            IWebElement apsvalga = chrome.FindElement(By.CssSelector("#main-header-next-button > span"));
            apsvalga.Click();
            string ResultText = chrome.FindElement(By.Id("total-price")).Text;
            Assert.AreEqual("179E", ResultText, "Text is wrong");

        }

        [Test]
        public static void additemtocard()
        {

            Thread.Sleep(5000);
            IWebElement popups = chrome.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAcceptWrapper"));
            popups.Click();
            IWebElement popup = chrome.FindElement(By.CssSelector("#sidenavWrapper > header > nav > div > button"));
            popup.Click();
            IWebElement prekes = chrome.FindElement(By.CssSelector("#navbarDropdownProducts > span"));
            prekes.Click();
            IWebElement kilimai = chrome.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li.headerMenuProducts__menu--item.nav-item.dropdown.productsMenu.show > div > div > div > div.col-lg-9.pl-0.products > a:nth-child(15)"));
            kilimai.Click();
            IWebElement pasirenkukilima = chrome.FindElement(By.CssSelector("#contentWrapper > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(3) > div > div.card-footer > button > span:nth-child(2)"));
            pasirenkukilima.Click();
            IWebElement cookies = chrome.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAcceptWrapper"));
            cookies.Click();
            IWebElement ideduikrepseli = chrome.FindElement(By.CssSelector("#sidenav > div > div.card-body > div > div > div:nth-child(2) > div > div.itemActionBlock > div.itemButtons > button.addToCart.btn.btn-yellow.btn-block.btn-icon.text-white"));
            ideduikrepseli.Click();


        }

        [Test]

        public static void addtofavorites()
        {

            Thread.Sleep(5000);
            IWebElement popups = chrome.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAcceptWrapper"));
            popups.Click();
            IWebElement popup = chrome.FindElement(By.CssSelector("#sidenavWrapper > header > nav > div > button"));
            popup.Click();
            IWebElement kambariai = chrome.FindElement(By.CssSelector("#navbarDropdownRooms > span"));
            kambariai.Click();
            IWebElement virtuve = chrome.FindElement(By.CssSelector("#headerMainToggler > div > div.container.headerMenuProducts > ul > li.headerMenuProducts__menu--item.nav-item.dropdown.servicesMenu.show > div > div > div > div > a:nth-child(1)"));
            virtuve.Click();
            IWebElement pasirenkumetoda = chrome.FindElement(By.CssSelector("#categories > div > div:nth-child(1) > a > span.text"));
            pasirenkumetoda.Click();
            IWebElement pasirenkumetodaa = chrome.FindElement(By.CssSelector("#categories > div > div:nth-child(1) > a > span.text"));
            pasirenkumetodaa.Click();
            IWebElement pasirenkubalda = chrome.FindElement(By.CssSelector("#contentWrapper > div > div > div.products_list.w-100.d-flex.flex-wrap > div:nth-child(1) > div > div.card-footer > button > span.icon-quickview"));
            pasirenkubalda.Click();
            // Thread.Sleep(5000);
            // IWebElement popupsq = chrome.FindElement(By.Id("CybotCookiebotDialogBodyLevelButtonAcceptWrapper"));
            // popupsq.Click();
            IWebElement prideduimegtamus = chrome.FindElement(By.CssSelector("#sidenav > div > div.card-body > div > div > div:nth-child(2) > div > div.itemActionBlock > div.itemButtons > button.addFavorites.btn.btn-block.btn-icon > span:nth-child(2)"));
            prideduimegtamus.Click();
        }

        [Test]

        public static void IKEAmedziagupasirinkimas()
        {
            chrome = new ChromeDriver();
            chrome.Url = "https://www.ikea.lt/lt";
            IWebElement popup = chrome.FindElement(By.CssSelector("#sidenavWrapper > header > nav > div > button"));
            popup.Click();
            IWebElement apie = chrome.FindElement(By.CssSelector("#hideOnScroll > ul.navbar.navbar-nav.servicesList.mr-lg-auto.ml-lg-auto.py-0.px-0.align-items-start > li:nth-child(1) > a"));
            apie.Click();
            IWebElement isplestipaieska = chrome.FindElement(By.CssSelector("#contentWrapper > div > div.row > div.col-12.col-lg-2.sectionMenu > div.col-12.px-0.smToggler.collapsed"));
            isplestipaieska.Click();
            IWebElement pasirinktizaliavas = chrome.FindElement(By.CssSelector("#smContainerToggler > div > a:nth-child(4) > p"));
            pasirinktizaliavas.Click();



        }
    }

    internal class OneTimesetupAttribute : Attribute
    {
    }
}


