using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Net.NetworkInformation;

namespace SeleniumCSharp
{
    [TestFixture]
    public class ReportModuleDemo
	{
            ExtentReports extent = null;

            [OneTimeSetUp]
            public void ExtentStart()
            {
                extent = new ExtentReports();
                var htmlReporter = new ExtentHtmlReporter("./ExtentReports/ReportModuleDemo.html");
                extent.AttachReporter(htmlReporter);
            }

            [OneTimeTearDown]
            public void ExtentClose()
            {
                extent.Flush();
            }

            [Test]
            public void Test1()
            {
                IWebDriver driver = null;
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test1").Info("Test Started");
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    test.Log(Status.Info, "Chrome Browser lauched");
                    driver.Url = "https://www.facebook.com/";
                    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                    emailTextField.SendKeys("Selenium C#");
                    test.Log(Status.Info, "Email id entered");
                    driver.Quit();
                    test.Log(Status.Pass, "Test1 Passed");
                }
                catch (Exception e)
                {

                    throw;
                }
                finally
                {
                    if (driver != null)
                    {
                        driver.Quit();
                    }
                }
            }

            [Test]
            public void Test2()
            {
                IWebDriver driver = null;
                ExtentTest test = null;
                try
                {
                    test = extent.CreateTest("Test2").Info("Test Started");
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    test.Log(Status.Info, "Chrome Browser lauched");
                    driver.Url = "https://www.facebook.com/";
                    IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));
                    emailTextField.SendKeys("Selenium C#");
                    test.Log(Status.Info, "Email id entered");
                    driver.Quit();
                    test.Log(Status.Pass, "Test1 Passed");
                }
                catch (Exception e)
                {
                    test.Log(Status.Fail, e.ToString());
                    throw;
                }
                finally
                {
                    if (driver != null)
                    {
                        driver.Quit();
                    }
                }
            }
        }
    }
