using OpenQA.Selenium;

namespace NUnitTestKandidate.PageObjects
{
    class SignupPage4
    {
        public static By Email = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[2]/div/input");
        public static By Language1 = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[4]/div/div/div/div[1]");
       // public static By Language2 = By.XPath("//*[@id='react - select - 3 - option - 37']");
        public static By Language2 = By.XPath("/html/body/div[1]/div/div/div/div/main/div[1]/form/div[4]/div/div/div[2]/div/div/div[1]");
        public static By Location = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[5]/div/input");
        public static By Date1 = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[6]/div/div/div[2]/div/input");
        public static By Date2 = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[6]/div/div/div[2]/div/div/div/div/div/div[2]/div/div[3]/div[3]/div[3]");
        public static By Password = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[8]/div/div/input");
        public static By ContactedBy = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[10]/ul/li[13]/div/label");
        public static By CompleteBtn = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/footer/div/button[2]/span[1]");

    }
}
