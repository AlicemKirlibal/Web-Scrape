using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
        
            IWebDriver driver = new FirefoxDriver();
            driver.Url = @"https://www.mavi.com/?gclid=Cj0KCQiAqNPyBRCjARIsAKA-WFxEp1u-JHKnTmY67LKG59XWuaLEjAoknA_Z7ld98wY8MGwn3DercyIaAtZGEALw_wcB";

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait.Add(System.TimeSpan.FromSeconds(7));

            driver.FindElement(By.XPath("//*[@id='mmenuDesktopOnly']/li[3]/a")).Click();

            //Listelemek için

            IList<IWebElement> elements = driver.FindElements(By.XPath("//*[@id='name']"));
            Console.WriteLine("Total product :" + elements.Count);

            for (int i = 0; i < elements.Count; i++)
            {
                Console.WriteLine(elements[i].Text);
            }

            Console.ReadKey();


        }
    }
}
