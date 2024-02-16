using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser.Models.Parsers
{
    public class YandexPatentsParser
    {
        IWebDriver driver;
        IReadOnlyCollection<IWebElement> titleInfo, subtitleInfo, dates;

        public Dictionary<string, List<string>> ParseYandexPatents(Dictionary<string, string> formData)
        {
            List<string> _names, _links, _documents, _applicants, _inventors, _applicationDate, _publicationDate, _effectiveDate;

            Dictionary<string, List<string>> forExcel = new Dictionary<string, List<string>>()
            {
                { "Название", _names = new List<string>() },
                { "Ссылка", _links = new List<string>() },
                { "Документ", _documents = new List<string>() },
                { "Заявитель", _applicants = new List<string>() },
                { "Изобретатель", _inventors = new List<string>() },
                { "Подача", _applicationDate = new List<string>() },
                { "Публикация", _publicationDate = new List<string>() },
                { "Начало действия", _effectiveDate = new List<string>() }
            };

            if (String.IsNullOrEmpty(formData["DocAmount"]))
                formData["DocAmount"] = "10";


            try
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

                driver.Navigate().GoToUrl("https://yandex.ru/patents");

                if (formData["isApplication"] == "Unchecked")
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[2]/span[1]/span/span/input")).Click();
                if (formData["isPatent"] == "Unchecked")
                    driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[2]/span[2]/span/span/input")).Click();

                driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div/header/div/div[1]/div[2]/form/div[1]/span/span/input")).SendKeys(formData["Keys"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[3]/div[2]/span/input")).SendKeys(formData["Document"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[4]/span/input")).SendKeys(formData["Application"]);

                //driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[5]/span/button")).Click();

                //if (formData["WhichDate"] == "Начало действия патента")
                //    driver.FindElement(By.XPath("")).Click();

                driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[6]/div[1]/span/input")).SendKeys(formData["DateStart"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[6]/div[2]/span/input")).SendKeys(formData["DateEnd"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[7]/span/input")).SendKeys(formData["Name"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[8]/span/input")).SendKeys(formData["Author"]);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[9]/span/input")).SendKeys(formData["Patentee"]);

                driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/div/div/header/div/div[1]/div[2]/form/div[2]/button")).Click();

                while (true)
                {
                    Thread.Sleep(2000);

                    titleInfo = driver.FindElements(By.ClassName("snippet-title"));
                    subtitleInfo = driver.FindElements(By.ClassName("subtitle"));
                    dates = driver.FindElements(By.ClassName("dates"));

                    bool flag = true;
                    foreach (IWebElement element in titleInfo)
                    {
                        if (flag == true)
                        {
                            _names.Add(element.Text);
                            _links.Add(element.FindElement(By.TagName("a")).GetAttribute("href").ToString());
                            flag = false;
                        }
                        else
                            flag = true;
                    }
                    foreach (IWebElement element in subtitleInfo)
                    {
                        string[] splittedSubtitle = element.Text.Split('•');

                        _documents.Add(splittedSubtitle[0]);
                        _applicants.Add(splittedSubtitle[1]);

                        if (splittedSubtitle.Length > 2)
                            _inventors.Add(splittedSubtitle[2]);
                        else
                            _inventors.Add(splittedSubtitle[1]);
                    }
                    foreach (IWebElement element in dates)
                    {
                        string[] splittedSubtitle = element.Text.Split('•');

                        _applicationDate.Add(splittedSubtitle[0].Replace("Подача", ""));
                        _publicationDate.Add(splittedSubtitle[1].Replace("Публикация", ""));
                        _effectiveDate.Add(splittedSubtitle[2].Replace("Начало действия", "").Replace("патент", "").Replace("заявка", ""));
                    }


                    if ((Int32.Parse(formData["DocAmount"]) > _names.Count) & (driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[1]/div[4]/div[1]/div[5]")).Displayed))
                    {
                        driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[1]/div[4]/div[1]/div[5]")).Click();
                        continue;
                    }

                    driver.Quit();

                    return forExcel;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                driver.Quit();
                return forExcel;
            }
        }
    }
}
