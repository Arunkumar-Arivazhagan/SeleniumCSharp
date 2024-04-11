using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp.BaseClass
{
	public class BaseTest
	{
		public IWebDriver driver;
        [SetUp] //[OneTimeSetup] to setup once and execute tests in unit test
		public void Open()
		{
            driver = new ChromeDriver();
			driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com";
        }

		[TearDown] //[OneTimeTearDown]
		public void Close()
		{
            driver.Quit();
        }
	}
}

