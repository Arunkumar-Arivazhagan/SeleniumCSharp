using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp.BaseClass
{
	public class BaseTest
	{
		public IWebDriver driver;
        [OneTimeSetUp]
		public void Open()
		{
            driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";
        }

		[OneTimeTearDown]
		public void Close()
		{
            driver.Quit();
        }
	}
}

