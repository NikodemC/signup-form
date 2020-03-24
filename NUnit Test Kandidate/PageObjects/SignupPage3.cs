using OpenQA.Selenium;

namespace NUnitTestKandidate.PageObjects
{
    class SignupPage3
    {
        public static By RoleDesc = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[2]/div/textarea");
        public static By IdealRole = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[3]/div[1]/div/ul/li[2]/label");
        public static By IdealRoleYears = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[3]/div[1]/div/ul/li[2]/div/div/input");
        public static By Tools = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[3]/div[2]/div/ul/li[1]/label");
        public static By Location = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[4]/div/ul/li[1]/label");
        public static By SalaryExp = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/form/div[5]/div/input");
        public static By NextButton = By.XPath("//*[@id='app']/div/div/div/div/main/div[1]/footer/div/button[2]/span[1]");

        
    }
}
