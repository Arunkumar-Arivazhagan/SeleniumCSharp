namespace SeleniumCSharp;
using OpenQA.Selenium;
using BaseClass;
using OpenQA.Selenium.Support.UI;

[TestFixture]
public class Tests : BaseTest
{
    [Test]
    public void Test1()
    {
        IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
        emailTestField.SendKeys("C#");
        Thread.Sleep(2000);
        
    }
    [Test, Category("Smoke")]
    public void Test2()
    {
        IWebElement createNewAccountBtn = driver.FindElement(By.XPath(".//*[@id='u_0_0_5d']"));
        Thread.Sleep(2000);
        createNewAccountBtn.Click();
        IWebElement monthField = driver.FindElement(By.XPath(".//*[@id='month']"));
        SelectElement select = new SelectElement(monthField);
        select.SelectByText("Mar");
        Thread.Sleep(2000);

    }
}
