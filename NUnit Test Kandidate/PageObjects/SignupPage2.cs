using OpenQA.Selenium;

namespace NUnitTestKandidate.PageObjects
{
    class SignupPage2

    {
        public static By Is_graduate = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[2]/ul/li[2]/label");
        public static By YEO_input = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[3]/div/input");
        public static By Sector = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[4]/ul/li[4]/label");
        public static By Job_title = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[6]/div/input");
        public static By Description = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[7]/div/textarea");
        public static By further_button = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/footer/div/button[2]/span[1]");
    }
}
