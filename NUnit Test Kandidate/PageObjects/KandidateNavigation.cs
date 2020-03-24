using OpenQA.Selenium;

namespace NUnitTestKandidate.PageObjects
{
    class KandidateNavigation
{
    public static By Recent_Searches = By.XPath("//*[@id='app']/div/div/div/div/nav/div[2]/ul/li[1]/a/span[1]");

    public static By Apply_filters = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/div/div[2]/button");
    public static By Clear_filters = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/div/div[2]/a");

    public static By Sector_sales = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[1]/div[2]/div/div[2]/ul/li[1]/label");
    public static By Role_field = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[2]/div/div/span/div/span");
    public static By Role_1st = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[2]/div[2]/div/div[2]/ul/li[1]/label");
    public static By Role_4th = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[2]/div[2]/div/div[2]/ul/li[4]/label");

    public static By Years = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[3]/div/div");
    public static By Years_Max = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[3]/div[2]/div/div[3]/div/input");

    public static By Salary_exp = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[4]/div/div/span");
    public static By Max_Salary_Field = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[4]/div[2]/div/div[3]/div/input");

    public static By Keywords = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[8]/div/div/span/span");
    public static By Keywords_field = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[8]/div[2]/div/div[2]/div/input");
    public static By Keywords_choosen = By.XPath("//*[@id='app']/div/div/div/div/div[2]/div/form/ul/li[5]/div[2]/ul/li");
}
}
