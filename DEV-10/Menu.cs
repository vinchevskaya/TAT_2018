using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace DEV_10
{
    public class Menu
    {
        IWebDriver driver;
        IWebElement mark;
        IWebElement model;
        IList<IWebElement> list;

        public Menu(IWebDriver driver)
        {
            this.driver = driver;
        }

        /// <summary>
        /// Here we choose the mark.
        /// </summary>
        public void ChooseMark(string markName)
        {
            if (!SearchMarkInList(markName))
            {
                throw new NoSuchElementException("No this mark in list of brands");
            }
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            mark = wait.Until(driver => driver.FindElement(By.XPath("//select[@name=\"brand_id[]\"]")));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].scrollIntoView();", mark);
            mark = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(mark));
            mark.Click();
            mark = wait.Until(driver => driver.FindElement(By.XPath("//option[contains(text(), \"" + markName + "\")]")));
            mark = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(mark));
            mark.Click();
        }

        public void SetModelList()
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            list = waiter.Until(driver => driver.FindElements(By.XPath("//select[@name=\"model_id[]\"]/option[@value]")));
        }

        public List<Car> GetModelList()
        {
            List<Car> carModels = new List<Car>();
            ModelSorter sorter = new ModelSorter();
            foreach (IWebElement element in list)
            {
                ChoiceOfModel(element.Text);
                WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
                Thread.Sleep(400);
                string quantityModel = waiter.Until(driver => driver.FindElement(By.XPath("//span[@class=\"moto-filter-form-counter-bike js-counter-all\"]"))).Text;
                carModels.Add(new Car(element.Text, GetModelNumber(quantityModel)));
            }
            return sorter.SortByDescendingNumberModels(carModels);
        }

        /// <summary>
        /// Here we are looking for a mark in List.
        /// </summary>
        private bool SearchMarkInList(string markName)
        {
            IList<IWebElement> markList;
            bool isContain = false;
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            markList = waiter.Until(driver => driver.FindElements(By.XPath("//select[@name=\"brand_id[]\"]/option[@value]")));
            foreach (IWebElement mark in markList)
            {
                if (mark.Text == markName)
                {
                    isContain = true;
                    break;
                }
            }
            return isContain;
        }

        /// <summary>
        /// Here we choose the model.
        /// </summary>
        private void ChoiceOfModel(string modelName)
        {
            WebDriverWait waiter = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            model = waiter.Until(driver => driver.FindElement(By.XPath("//select[@name=\"model_id[]\"]")));
            model = waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(model));
            model.Click();
            model = waiter.Until(driver => driver.FindElement(By.XPath("//option[contains(text(), \"" + modelName + "\")]")));
            model = waiter.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(model));
            model.Click();
        }

        private int GetModelNumber(string quantityModel)
        {
            char[] separator = new char[1] { ' ' };
            string[] modelNumber = quantityModel.Split(separator);
            return Int32.Parse(modelNumber[0]);
        }
    }
}
