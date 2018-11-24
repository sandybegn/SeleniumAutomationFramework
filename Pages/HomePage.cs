using OpenQA.Selenium;
using OpenQA.Selenium.Support;

public class HomePage{

    By MyAccountLink = By.CssSelector("a[title='My Account']");

    public bool OpenMyAccount()
    {
        Driver._driver.FindElement(MyAccountLink).Click();
        return true;
    }

}