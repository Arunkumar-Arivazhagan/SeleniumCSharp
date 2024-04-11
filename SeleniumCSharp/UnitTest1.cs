namespace SeleniumCSharp;
using OpenQA.Selenium;
using BaseClass;

[TestFixture]
public class Tests : BaseTest
{
    [Test]
    public void Test1()
    {
        IWebElement emailTestField = driver.FindElement(By.XPath(".//*[@id='email']"));
        emailTestField.SendKeys("C#");
        
    }
}
