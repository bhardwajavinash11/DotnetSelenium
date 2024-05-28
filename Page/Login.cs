using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetSelenium.Page
{
    public class Login
    {
        private readonly IWebDriver driver;

        public Login(IWebDriver driver)
        {
            this.driver = driver;
        }

        IWebElement userNameInputBox => driver.FindElement(By.Id("user-name"));
        IWebElement passwordInputBox => driver.FindElement(By.Id("password"));
        IWebElement loginButton => driver.FindElement(By.Id("login-button"));

        public void InputUserName()
        {
            userNameInputBox.SendKeys("standard_user");
        }

        public void InputPassword()
        {
            passwordInputBox.SendKeys("secret_sauce");
        }

        public void ClickLogin()
        {
            loginButton.Click();
        }
    }
}

