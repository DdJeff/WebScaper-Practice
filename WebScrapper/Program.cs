using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WebScrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            //use to test different network speeds

            /*ChromeNetworkConditions conditions = new ChromeNetworkConditions();
            conditions.DownloadThroughput = 45 * 1000;
            conditions.UploadThroughput = 10 * 1000;
            conditions.Latency = TimeSpan.FromMilliseconds(1);*/




            // Simple web scrapper mini project//
            
            //make a new instance of a chrome driver obj
            IWebDriver driver = new ChromeDriver();

            //navigate to google.com
            driver.Navigate().GoToUrl("https://www.google.com");

            //selecte the search bar by its id
            var element = driver.FindElement(By.Name("q"));

            //what to search for
            element.SendKeys("youtube");

            //submitting keyword
            element.Submit();

            //getting all the results
            var titles = driver.FindElements(By.XPath("//*[@id=\"rso\"]/div/div/div/div/div"));

            //looping through all the results
            foreach (var title in titles)
            {
                Console.WriteLine(title.Text);
            }

            //===============================================================

            //Mini Project two

            //=================================================================

            //var driver = new ChromeDriver();

            //driver.Navigate().GoToUrl("https://www.reverbnation.com");

            //var driverBtn = driver.FindElementById("menu-item-discover");
            //// if element is hidden (by hamburger) becasue of screen size
            //driverBtn.Click();


            //var collections = driver.FindElementsByClassName("card_content");

            //foreach (var item in collections)
            //{
            //    Console.WriteLine(item.Text);
            //}

        
            //===============================================================

            //Mini project three

            //=================================================================


            //to just scrape paragraphes

            ////running in headless mode
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless"); //no UI
            //options.AddArgument("log-level =3"); //excludes js console writes

            //IWebDriver driver = new ChromeDriver(options);
            //driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Seventh-day_Adventist_Church");

            ////get all the paragraphes
            //var par = driver.FindElements(By.TagName("p"));
            //Console.WriteLine(par.Count);

            ////Find first paragraph that has text
            //var firstPar = par.First(x => !string.IsNullOrEmpty(x.Text));

            //Console.WriteLine(firstPar.Text);

            //How to use JavaScript

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Football");

           // var item = driver.FindElement(By.ClassName("toctext"));

            //item.Click();

            //Console.WriteLine(((IJavaScriptExecutor)driver).ExecuteScript("return arguments[0].textContent", item));
           // Console.WriteLine(item.Text);

        }
    }
}
