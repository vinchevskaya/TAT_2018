using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DEV_9
{
    class Login
    {
        /// <summary>
        /// This class comes to the page VK,
        /// clicks the Messages button, reads the first message
        /// and closes the browser.
        /// </summary>
        IWebDriver driver = new ChromeDriver();              
        public void News(string login, string password)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            driver.Url = "https://vk.com/";
            if (driver.Url != "https://vk.com/")
            {
                throw new Exception("Error");
            }
            driver.FindElement(By.XPath("//*[@id='index_email']")).SendKeys(login);
            driver.FindElement(By.XPath("//*[@id='index_pass']")).SendKeys(password + Keys.Enter);

            IWebElement element = driver.FindElement(By.XPath("//li[@id='l_msg']"));
            element.Click();

            IWebElement firstElement = driver.FindElement(By.XPath("//*[@id='im_dialogs']/li[1]"));
            element.Click();
            
            driver.Quit();
        }
    }
}
