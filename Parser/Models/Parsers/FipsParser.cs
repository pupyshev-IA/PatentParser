using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Parser.Models.Parsers
{
    public class FipsParser
    {
        IWebDriver driver;
        IReadOnlyCollection<IWebElement> patentsInfo;

        public Dictionary<string, List<string>> ParseFips(Dictionary<string, string> formData)
        {
            List<string> _names, _links, _numbers, _dates;

            Dictionary<string, List<string>> forExcel = new Dictionary<string, List<string>>()
            {
                { "Название", _names = new List<string>() },
                { "Ссылка", _links = new List<string>() },
                { "Номер документа", _numbers = new List<string>() },
                { "Дата публикации", _dates = new List<string>() }
            };

            if (String.IsNullOrEmpty(formData["DocAmount"]))
                formData["DocAmount"] = "50";


            try
            {
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

                driver.Navigate().GoToUrl("https://www1.fips.ru/iiss/");

                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div[2]/form/div[1]")).Click();
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div[2]/form/div[1]/div[3]/div[1]/div/table/tbody/tr[1]/td[1]/div/div[1]/input")).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div[2]/form/div[1]/div[3]/div[2]/div[1]/input")).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[1]/div[2]/textarea")).SendKeys(formData["Keys"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[3]/div[2]/input")).SendKeys(formData["Name"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[4]/div[2]/input")).SendKeys(formData["DocNum"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[5]/div[2]/input")).SendKeys(formData["Date"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[6]/div[2]/input")).SendKeys(formData["MPK"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[7]/div[2]/input")).SendKeys(formData["Applicant"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[8]/div[2]/input")).SendKeys(formData["Author"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[9]/div[2]/input")).SendKeys(formData["Patentee"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[10]/div[2]/input")).SendKeys(formData["PublicationDate"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[13]/div[2]/input")).SendKeys(formData["DateRTS"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[14]/div[2]/input")).SendKeys(formData["NumRTS"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[15]/div[2]/input")).SendKeys(formData["Correspondence"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[17]/div[2]/input")).SendKeys(formData["ViewCode"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[19]/div[2]/input")).SendKeys(formData["RegNum"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[20]/div[2]/input")).SendKeys(formData["ApplicationDate"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[21]/div[2]/input")).SendKeys(formData["ConventionPriority"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[22]/div[2]/input")).SendKeys(formData["ConventionDate"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[23]/div[2]/input")).SendKeys(formData["PriorityCountry"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[24]/div[2]/input")).SendKeys(formData["Essay"]);
                driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div/form/div[1]/div[25]/div[2]/input")).SendKeys(formData["Formula"]);

                driver.FindElement(By.Name("j_idt92")).Click();

                var buttonNextId = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/form/div[5]/a[6]")).GetAttribute("id");

                while (true)
                {
                    Thread.Sleep(2000);

                    patentsInfo = driver.FindElements(By.ClassName("tr"));

                    foreach (IWebElement element in patentsInfo)
                    {
                        string[] splittedString = element.Text.Split(new char[] { ' ', '(', ')' }, 4, StringSplitOptions.RemoveEmptyEntries);

                        if (splittedString[1] != "Номер")
                        {
                            _names.Add(splittedString[3].Substring(0, splittedString[3].Length - 3));
                            _links.Add(element.GetAttribute("href").ToString());
                            _numbers.Add(splittedString[1]);
                            _dates.Add(splittedString[2]);
                        }
                    }


                    if ((Int32.Parse(formData["DocAmount"]) > _names.Count) & (driver.FindElement(By.Id(buttonNextId)).Displayed))
                    {
                        driver.FindElement(By.Id(buttonNextId)).Click();
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
