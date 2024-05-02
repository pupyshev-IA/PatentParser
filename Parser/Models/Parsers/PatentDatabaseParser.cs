using System;
using System.Collections.Generic;
using System.Threading;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Linq;

namespace Parser.Models.Parsers
{
    public class PatentDatabaseParser
    {
        public Dictionary<string, List<string>> ParseEspacenet(Dictionary<string, string> formData)
        {
            List<string> _names, _links, _priorityDate, _inventor, _applicants, _srs, _ipc, _info;
            IReadOnlyCollection<IWebElement> titleInfo, priorityDates, inventors, applicants, srs, ipc, info;

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

            IWebDriver driver = new ChromeDriver();

            try
            {
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

                Thread.Sleep(1000);
                string newKey = "ResultAmount";
                string newValue = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div[2]/div[3]/div[1]/div/p[1]/b")).Text;
                formData.Add(newKey, newValue);

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
            catch
            {
                driver.Quit();
                return forExcel;
            }
        }

        public Dictionary<string, List<string>> ParseYandexPatents(Dictionary<string, string> formData)
        {
            List<string> _names, _links, _documents, _applicants, _inventors, _applicationDate, _publicationDate, _effectiveDate;
            IReadOnlyCollection<IWebElement> titleInfo, subtitleInfo, dates;

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

            IWebDriver driver = new ChromeDriver();

            try
            {
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

                Thread.Sleep(3000);
                string newKey = "ResultAmount";
                string newValue = driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[2]")).Text.Replace("Нашлось документов: ", "");
                formData.Add(newKey, newValue);

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
            catch
            {
                driver.Quit();
                return forExcel;
            }
        }

        public Dictionary<string, List<string>> ParseFips(Dictionary<string, string> formData)
        {
            List<string> _names, _links, _numbers, _dates;
            IReadOnlyCollection<IWebElement> patentsInfo;

            Dictionary<string, List<string>> forExcel = new Dictionary<string, List<string>>()
            {
                { "Название", _names = new List<string>() },
                { "Ссылка", _links = new List<string>() },
                { "Номер документа", _numbers = new List<string>() },
                { "Дата публикации", _dates = new List<string>() }
            };

            if (String.IsNullOrEmpty(formData["DocAmount"]))
                formData["DocAmount"] = "50";

            IWebDriver driver = new ChromeDriver();

            try
            {
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

                var buttonNextId = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/form/div[5]/span[4]")).GetAttribute("id");

                Thread.Sleep(1000);
                string newKey = "ResultAmount";
                string newValue = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div/div[1]/div/div/div[1]/b[1]")).Text;
                formData.Add(newKey, newValue);

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
            catch
            {
                driver.Quit();
                return forExcel;
            }
        }

        public Dictionary<string, List<string>> ParseWipo(Dictionary<string, string> formData)
        {
            string[] conditionFields = 
            { 
                "Любое поле", "Название на английском", "Текст на английском", "Автор", "Имя изобретателя",
                "Страна", "Номер заявки", "Номер приоритетного документа", "Номер публикации", "Дата подачи",
                "Дата публикации", "Дата приоритета", "Класс МПК", "Точный код МПК", "Язык публикации",
                "Код ведомства", "Издательство", "Формула изобретения на английском",
            };

            string[] conditionValues = formData.Select(x => x.Value).ToArray();

            List<string> _names, _links, _numbers, _dates, _applicants, _inventors;
            IWebElement patentsInfo;

            Dictionary<string, List<string>> forExcel = new Dictionary<string, List<string>>()
            {
                { "Название", _names = new List<string>() },
                { "Ссылка", _links = new List<string>() },
                { "Номер документа", _numbers = new List<string>() },
                { "Дата публикации", _dates = new List<string>() },
                { "Заявитель", _applicants = new List<string>() },
                { "Изобретатель", _inventors = new List<string>() },
            };

            if (String.IsNullOrEmpty(formData["DocAmount"]))
                formData["DocAmount"] = "20";

            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

                driver.Navigate().GoToUrl("https://patentscope.wipo.int/search/ru/structuredSearch.jsf");
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div[5]/div/div[1]/form/div[2]/div[1]/a")));

                for (int i = 0; i < formData.Count - 6; i++)
                {
                    driver.FindElement(By.XPath("/html/body/div[2]/div[5]/div/div[1]/form/div[2]/div[1]/a")).Click();
                    Thread.Sleep(800);
                }

                var textBoxes = driver.FindElement(By.Id("structuredSearchForm:j_idt1217"))
                    .FindElements(By.ClassName("ui-grid-row"));

                int Id = 0;
                SelectElement select;
                foreach (var textBox in textBoxes)
                {
                    if (Id > conditionFields.Length - 1)
                        continue;

                    if (Id == 0)
                        select = new SelectElement(textBox.FindElement(By.Id($"structuredSearchForm:conditions:{Id}:firstConditionField:input")));
                    else
                        select = new SelectElement(textBox.FindElement(By.Id($"structuredSearchForm:conditions:{Id}:conditionField:input")));

                    select.SelectByText(conditionFields[Id]);
                    textBox.FindElement(By.Id($"structuredSearchForm:conditions:{Id}:conditionValue:input")).SendKeys(conditionValues[Id]);

                    Id++;
                }

                driver.FindElement(By.XPath("/html/body/div[2]/div[5]/div/div[1]/form/div[3]/div[2]/div/div[2]/button[2]")).Click();

                string newKey = "ResultAmount";
                string newValue = driver.FindElement(By.ClassName("results-count")).Text;
                formData.Add(newKey, newValue.Replace(" результат/результата/результатов", "").Replace(" ", ""));

                bool isFirstPage = true;

                while (true)
                {
                    Thread.Sleep(1000);

                    patentsInfo = driver.FindElement(By.Id("resultListForm:resultTable_data"));
                    var info = patentsInfo.FindElements(By.TagName("tr"));

                    foreach (IWebElement element in info)
                    {
                        var name = element.FindElement(By.ClassName("ps-patent-result--title--title")).Text;
                        var link = element.FindElement(By.ClassName("ps-patent-result--title"))
                                          .FindElement(By.TagName("a")).GetAttribute("href");
                        var num = element.FindElement(By.TagName("a")).Text;

                        var date = element.FindElement(By.ClassName("ps-patent-result--title--ctr-pubdate")).Text;
                        int index = date.IndexOf("- ");
                        date = date.Substring(index + 2);

                        var applicant = Regex.Match(element.FindElement(By.ClassName("ps-patent-result--fields--group")).Text, @"Заявитель ([^\n]+)").Value;
                        applicant = applicant.Replace("Заявитель ", "");

                        var inventor = Regex.Match(element.FindElement(By.ClassName("ps-patent-result--fields--group")).Text, @"Изобретатель ([^\n]+)").Value;
                        inventor = inventor.Replace("Изобретатель ", "");

                        _names.Add(name);
                        _links.Add(link);
                        _numbers.Add(num);
                        _dates.Add(date);
                        _applicants.Add(applicant);
                        _inventors.Add(inventor);
                    }


                    IWebElement nextButton;
                    if (isFirstPage)
                    {
                        nextButton = driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div[1]/div[2]/div/form[1]/div/div[2]/a"));
                        isFirstPage = false;
                    }
                    else
                        nextButton = driver.FindElement(By.XPath("/html/body/div[2]/div[4]/div/div[1]/div[2]/div/form[1]/div/div[2]/a[2]"));
                    
                    if ((Int32.Parse(formData["DocAmount"]) > _names.Count) & nextButton.Displayed)
                    {
                        nextButton.Click();
                        continue;
                    }

                    driver.Quit();

                    return forExcel;
                }
            }
            catch
            {
                driver.Quit();
                return forExcel;
            }
        }

        public Dictionary<string, List<string>> ParseRospatent(Dictionary<string, string> formData)
        {
            List<string> _names, _links, _numbers, _dates, _applicants, _inventors;

            Dictionary<string, List<string>> forExcel = new Dictionary<string, List<string>>()
            {
                { "Название", _names = new List<string>() },
                { "Ссылка", _links = new List<string>() },
                { "Номер документа", _numbers = new List<string>() },
                { "Дата публикации", _dates = new List<string>() },
                { "Заявитель", _applicants = new List<string>() },
                { "Изобретатель", _inventors = new List<string>() },
            };

            if (String.IsNullOrEmpty(formData["DocAmount"]))
                formData["DocAmount"] = "20";

            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

                driver.Navigate().GoToUrl("https://searchplatform.rospatent.gov.ru/patents");
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[2]/div/div/div[1]/input")).SendKeys(formData["Keys"]);
                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[3]/div[1]/div[1]/div[1]/input")).SendKeys(formData["DocNum"]);
                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[3]/div[1]/div[1]/div[2]/div[2]/div/div/input")).SendKeys(formData["DateStart"]);
                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[3]/div[1]/div[1]/div[3]/div[2]/div/div/input")).SendKeys(formData["DateEnd"]);
                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[3]/div[1]/div[2]/div/input")).SendKeys(formData["Author"]);
                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[3]/div[1]/div[3]/div/input")).SendKeys(formData["Patentee"]);
                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[3]/div[1]/div[4]/div/input")).SendKeys(formData["Applicant"]);
                
                driver.FindElement(By.XPath("/html/body/div/div/div[3]/div/div[2]/div/div/button")).Click();

                string newKey = "ResultAmount";
                string newValue = driver.FindElement(By.ClassName("total")).Text.Replace("Всего найдено: ", "");
                formData.Add(newKey, newValue);

                while (true)
                {
                    Thread.Sleep(500);

                    var patentsInfo = driver.FindElement(By.ClassName("report_items"));
                    var titleRow = patentsInfo.FindElements(By.ClassName("report_title_row"));
                    var infoRow = patentsInfo.FindElements(By.ClassName("report_info"));
                    
                    foreach (var title in titleRow)
                        _names.Add(title.Text);

                    foreach (var info in infoRow)
                    {
                        string[] lines = info.Text.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var el in lines)
                        {
                            if (el.Contains("Документ "))
                            {
                                var doc = el.Replace("Документ ", "");
                                doc = doc.Substring(0, doc.Length - 11);
                                _numbers.Add(doc);

                                var date = Regex.Match(el, @"\d{4}\.\d{2}\.\d{2}").Value;
                                _dates.Add(date);

                                _links.Add($"https://searchplatform.rospatent.gov.ru/doc/{doc.Replace(" ", "")}_{date.Replace(".", "")}");
                            }

                            if (el.Contains("Заявитель "))
                                _applicants.Add(el.Replace("Заявитель ", ""));

                            if (el.Contains("Автор "))
                                _inventors.Add(el.Replace("Автор ", ""));
                        }
                    }


                    var nextButton = driver.FindElement(By.ClassName("pagNextPage_ru"));
                    if ((Int32.Parse(formData["DocAmount"]) > _names.Count) & nextButton.Displayed)
                    {
                        nextButton.Click();
                        continue;
                    }

                    driver.Quit();

                    return forExcel;
                }
            }
            catch
            {
                driver.Quit();
                return forExcel;
            }
        }
    }
}
