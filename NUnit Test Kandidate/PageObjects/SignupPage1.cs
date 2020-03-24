using OpenQA.Selenium;

namespace NUnitTestKandidate.PageObjects
{
    class SignupPage1

    {
        public static By further_button = By.XPath("//*[@id='app']/div/div/div/div/div[2]/button");
        public static By name_input = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[2]/div/input");
        public static By surname_input = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[3]/div/input");
        public static By citizenship_input = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[4]/div/div/div/div[1]");
        public static By citizenship_input1 = By.XPath("/html/body/div[4]/div/div/div/div[1]");
        public static By next_button = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/footer/div/button/span[1]");

            

    }
}
