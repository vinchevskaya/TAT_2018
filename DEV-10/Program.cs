using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace DEV_10
{
    /// <summary>
    /// This is entry point to the program.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ChromeDriver driver = new ChromeDriver();
                driver.Navigate().GoToUrl("https://av.by");
                driver.Manage().Window.Maximize();
                Menu menu = new Menu(driver);
                menu.ChooseMark(args[0]);
                menu.SetModelList();
                List<Car> cars = menu.GetModelList();
                foreach (Car car in cars)
                {
                    Console.WriteLine(car);
                }
                driver.Quit();
            }
            catch (NoSuchElementException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
