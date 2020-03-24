using OpenQA.Selenium;

namespace NUnitTestKandidate.PageObjects
{
    class KandidateLogin
{
    public static By email_input = By.XPath("//*[@id='app']/div/div/div/div/form/div[2]/div/div/input");
    public static By further_button = By.XPath("//*[@id='app']/div/div/div/div/form/div[4]/button");
    public static By password_input = By.XPath("//*[@id='app']/div/div/div/div/form/div[3]/div/div/input");

}
}
