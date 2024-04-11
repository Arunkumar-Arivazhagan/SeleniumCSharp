using System;
using SeleniumCSharp.BaseClass;
using SeleniumCSharp.Pages;

namespace SeleniumCSharp.PageObjectModelScript
{
    [TestFixture]
    public class ModuleOne : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            var searchpage = new SearchPage(driver);
            var resultpage = searchpage.NavigateToResultPage();
            var channelpage = resultpage.NavigateToChannel();
            String actualChannelName = channelpage.getChannelName();
            String expectedChannelName = "Selenium Java Tutorials - Bakkappa N";
            Assert.IsTrue(actualChannelName.Equals(expectedChannelName));
            Thread.Sleep(5000);
        }

    }
}

