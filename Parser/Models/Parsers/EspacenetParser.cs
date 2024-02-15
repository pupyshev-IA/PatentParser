using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser.Models.Parsers
{
    public class EspacenetParser
    {
        IWebDriver driver;
        IReadOnlyCollection<IWebElement> titleInfo, priorityDates, inventors, applicants, srs, ipc, info;

        public Dictionary<string, List<string>> ParseEspacenet(Dictionary<string, string> formData)
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

            if (String.IsNullOrEmpty(formData["DocAmount"]))
                formData["DocAmount"] = "25";


            try
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

                driver.Navigate().GoToUrl("https://worldwide.espacenet.com/advancedSearch?locale=en_EP");

                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[2]/div[1]/span[3]/textarea")).SendKeys(formData["KeysName"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[2]/div[2]/span[3]/textarea")).SendKeys(formData["KeysText"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[3]/div[1]/span[3]/textarea")).SendKeys(formData["PublicationNum"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[3]/div[2]/span[3]/textarea")).SendKeys(formData["ApplicationNum"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[3]/div[3]/span[3]/textarea")).SendKeys(formData["DocNum"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[4]/div/span[3]/textarea")).SendKeys(formData["Date"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[5]/div[1]/span[3]/textarea")).SendKeys(formData["Applicant"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[5]/div[2]/span[3]/textarea")).SendKeys(formData["Inventor"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[6]/div[1]/span[3]/textarea")).SendKeys(formData["SRS"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/fieldset[6]/div[2]/span[3]/textarea")).SendKeys(formData["MPK"]);

                driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div/div/form/div/div[2]/div[2]/div/span/input")).Click();

                while (true)
                {
                    Thread.Sleep(2000);

                    titleInfo = driver.FindElements(By.ClassName("publicationLinkClass"));
                    priorityDates = driver.FindElements(By.ClassName("nowrap"));
                    inventors = driver.FindElements(By.ClassName("inventorColumn"));
                    applicants = driver.FindElements(By.ClassName("applicantColumn"));
                    srs = driver.FindElements(By.ClassName("cpcColumn"));
                    ipc = driver.FindElements(By.ClassName("ipcColumn"));
                    info = driver.FindElements(By.ClassName("publicationInfoColumn"));

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


                    if ((Int32.Parse(formData["DocAmount"]) > _names.Count) & (driver.FindElement(By.Id("nextPageLinkBottom")).Displayed))
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
                //MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                driver.Quit();
                return forExcel;
            }
        }
    }
}
