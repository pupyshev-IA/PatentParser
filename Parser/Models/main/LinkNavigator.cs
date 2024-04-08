using System;
using System.Diagnostics;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Threading;
using System.Windows.Forms;

namespace Parser.Models.main
{
    public class LinkNavigator
    {
        public void OpenLink(string url, string docNum)
        {
            if (url.Contains("fips"))
            {
                IWebDriver driver = new ChromeDriver();

                try
                {
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

                    driver.Navigate().GoToUrl("https://www1.fips.ru/iiss/");

                    driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div[2]/form/div[1]")).Click();
                    driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div[2]/form/div[1]/div[3]/div[1]/div/table/tbody/tr[1]/td[1]/div/div[1]/input")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div[2]/form/div[1]/div[3]/div[2]/div[1]/input")).Click();
                    
                    driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[4]/div[2]/input")).SendKeys(docNum);
                    driver.FindElement(By.Name("j_idt92")).Click();

                    Thread.Sleep(1000);

                    var el = driver.FindElements(By.ClassName("tr"));

                    driver.Navigate().GoToUrl(el[1].GetAttribute("href"));
                }
                catch
                {
                    driver.Quit();
                    MessageBox.Show("Неудалось открыть текущую ссылку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                Process.Start(url);
            }
        }
    }
}
