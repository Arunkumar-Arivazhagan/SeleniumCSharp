using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp.Utility
{
	public class BrowserUtility
	{ public IWebDriver Init(IWebDriver driver)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = "https://www.facebook.com/";
                return driver;
            }
        }
	}


