using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace treciadalis.tools
{
    public class screenshot
    {
        public static void TakeScreenshot(IWebDriver driver) 
        {
            Screenshot screenshot = driver.TakeScreenshot();
            String screenshotDirectory = Assembly.GetExecutingAssembly().Location;
            Console.Out.WriteLine(screenshotDirectory);

        }

    }
}
