using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser.Models.Parsers
{
    static class EspacenetParser
    {
        public static Dictionary<string, List<string>> ParseEspacenet(string nameKeys, string nameOrEssay, string publicationNum, string applicationNum, 
            string priorityNum, string publicationDate, string applicant, string inventor, string SRS, string MPK, string DocAmount)
        {
            List<string> _names, _links, _priorityDate, _inventor, _applicants, _srs, _ipc, _info;

            Dictionary<string, List<string>> forExcel = new Dictionary<string, List<string>>()
            {
                { "Название", _names = new List<string>() },
                { "Ссылка", _links = new List<string>() },
                { "Дата приоритета", _priorityDate = new List<string>() },
                { "Изобретатель", _inventor = new List<string>() },
                { "Заявитель", _applicants = new List<string>() },
                { "CPC", _srs = new List<string>() },
                { "МПК", _ipc = new List<string>() },
                { "Информация о публикации", _info = new List < string >() },
            };

            if (String.IsNullOrEmpty(DocAmount))
                DocAmount = "25";


            try
            {
                IWebDriver driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

                driver.Navigate().GoToUrl("https://worldwide.espacenet.com/advancedSearch?locale=en_EP");

                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[2]/div[1]/span[3]/textarea")).SendKeys(nameKeys);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[2]/div[2]/span[3]/textarea")).SendKeys(nameOrEssay);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[3]/div[1]/span[3]/textarea")).SendKeys(publicationNum);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[3]/div[2]/span[3]/textarea")).SendKeys(applicationNum);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[3]/div[3]/span[3]/textarea")).SendKeys(priorityNum);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[4]/div/span[3]/textarea")).SendKeys(publicationDate);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[5]/div[1]/span[3]/textarea")).SendKeys(applicant);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[5]/div[2]/span[3]/textarea")).SendKeys(inventor);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[6]/div[1]/span[3]/textarea")).SendKeys(SRS);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[6]/div[2]/span[3]/textarea")).SendKeys(MPK);

                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/div/div[2]/div[2]/div/span/input")).Click();

                while (true)
                {
                    Thread.Sleep(2000);

                    IReadOnlyCollection<IWebElement> titleInfo = driver.FindElements(By.ClassName("publicationLinkClass"));
                    IReadOnlyCollection<IWebElement> priorityDates = driver.FindElements(By.ClassName("nowrap"));
                    IReadOnlyCollection<IWebElement> inventors = driver.FindElements(By.ClassName("inventorColumn"));
                    IReadOnlyCollection<IWebElement> applicants = driver.FindElements(By.ClassName("applicantColumn"));
                    IReadOnlyCollection<IWebElement> srs = driver.FindElements(By.ClassName("cpcColumn"));
                    IReadOnlyCollection<IWebElement> ipc = driver.FindElements(By.ClassName("ipcColumn"));
                    IReadOnlyCollection<IWebElement> info = driver.FindElements(By.ClassName("publicationInfoColumn"));


                    foreach (IWebElement element in titleInfo)
                    {
                        _names.Add(element.Text);
                        _links.Add(element.GetAttribute("href").ToString());
                    }
                    foreach (IWebElement element in priorityDates)
                    {
                        string result = element.Text;
                        result = Regex.Replace(result, "Priority date:", "").Replace("\r\n", "");
                        _priorityDate.Add(result);
                    }

                    foreach (IWebElement element in inventors)
                    {
                        string result = element.Text;
                        result = Regex.Replace(result, "Inventor:", "").Replace("\r\n", " ");
                        _inventor.Add(result);
                    }
                    foreach (IWebElement element in applicants)
                    {
                        string result = element.Text;
                        result = Regex.Replace(result, "Applicant:", "").Replace("\r\n", " ");
                        _applicants.Add(result);
                    }
                    foreach (IWebElement element in srs)
                    {
                        string result = element.Text;
                        result = Regex.Replace(result, "CPC:", "").Replace("\r\n", " ");
                        _srs.Add(result);
                    }
                    foreach (IWebElement element in ipc)
                    {
                        string result = element.Text;
                        result = Regex.Replace(result, "IPC:", "").Replace("\r\n", " ");
                        _ipc.Add(result);
                    }
                    foreach (IWebElement element in info)
                    {
                        string result = element.Text;
                        result = Regex.Replace(result, "Publication info:", "").Replace("\r\n", " ");
                        _info.Add(result);
                    }


                    if ((Int32.Parse(DocAmount) > _names.Count) & (driver.FindElement(By.Id("nextPageLinkBottom")).Displayed))
                    {
                        driver.FindElement(By.Id("nextPageLinkBottom")).Click();
                        continue;
                    }

                    driver.Quit();

                    return forExcel;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return forExcel;
            }
        }
    }
}
