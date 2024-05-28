namespace DotnetSelenium
{
    using DotnetSelenium.Page;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;


    namespace CSharp_Selenium
    {
        public class Tests
        {
            [Test]
            public void Test1()
            {
                IWebDriver driver = new ChromeDriver();

                Login login = new Login(driver);

                driver.Navigate().GoToUrl("https://www.saucedemo.com/");

                login.InputUserName();
                login.InputPassword();
                login.ClickLogin();

                driver.Quit();
            }
        }
    }
}