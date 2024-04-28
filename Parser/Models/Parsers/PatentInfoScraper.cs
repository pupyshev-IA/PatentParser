using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Net;
using System.Data.SqlTypes;

namespace Parser.Models.Parsers
{
    public class PatentInfoScraper
    {
        public Dictionary<string, string> FetchEspacenetPatent(string link, string docNum)
        {
            Dictionary<string, string> response = new Dictionary<string, string>()
            {
                { "Название", null },
                { "Номер документа", null },
                { "Автор", null },
                { "Заявитель", null },
                { "МПК", null },
                { "Реферат", null },
                { "Изображение", null },
            };

            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.Navigate().GoToUrl(link);

                var name = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/h3")).Text;
                response["Название"] = name;

                var number = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div[2]/table/tbody/tr[6]/td")).Text;
                response["Номер документа"] = number;

                var inventor = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div[2]/table/tbody/tr[3]/td/span[1]")).Text;
                response["Автор"] = inventor;

                var applicant = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div[2]/table/tbody/tr[4]/td/span[1]")).Text;
                response["Заявитель"] = applicant;
                
                var ipc = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div[2]/table/tbody/tr[5]/td/table/tbody/tr[1]/td")).Text;
                response["МПК"] = ipc;

                var text = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div[2]/div[2]/p[1]")).Text;
                response["Реферат"] = text;

                IWebElement imageElement = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div/div[2]/div[2]/img"));
                string imageUrl = imageElement.GetAttribute("src");
                byte[] imageBytes = new WebClient().DownloadData(imageUrl);
                string imageString = Convert.ToBase64String(imageBytes);
                response["Изображение"] = imageString;

                driver.Quit();
                return response;
            }
            catch
            {
                driver.Quit();
                return response;
            }
        }

        public Dictionary<string, string> FetchYandexPatentsPatent(string link, string docNum)
        {
            string pattern = @"\s+";

            Dictionary<string, string> response = new Dictionary<string, string>()
            {
                { "Название", null },
                { "Номер документа", null },
                { "Автор", null },
                { "Заявитель", null },
                { "МПК", null },
                { "Реферат", null },
                { "Изображение", null },
            };

            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
                driver.Navigate().GoToUrl(link);
                Thread.Sleep(1000);

                var name = driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[1]/h1")).Text;
                response["Название"] = name;

                var number = driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[3]/div[1]/h2")).Text;
                response["Номер документа"] = number;

                var ipc = driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[1]/div[2]/div[2]")).Text;
                int index = ipc.IndexOf("МПК");
                ipc = ipc.Substring(index + "МПК".Length).Replace("МПК", "");
                response["МПК"] = Regex.Replace(ipc, pattern, " ");

                var text = driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[4]/div[2]")).Text;
                response["Реферат"] = text;

                var info = driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[2]/div[2]")).Text;
                info = Regex.Replace(info, pattern, " ");

                var inventor = Regex.Match(info, @"Авторы: ([^\(]+)").Value;
                response["Автор"] = inventor.Replace("Авторы: ", "");

                var applicant = Regex.Match(info, @"Патентообладатели: ([^\(]+)").Value;
                response["Заявитель"] = applicant.Replace("Патентообладатели: ", "");

                //IWebElement imageElement = driver.FindElement(By.XPath("/html/body/div[1]/div/div[6]/div[2]/div[3]/div[2]/div/div/img"));
                //string imageUrl = imageElement.GetAttribute("src");
                //byte[] imageBytes = new WebClient().DownloadData(imageUrl);
                //string imageString = Convert.ToBase64String(imageBytes);
                //response["Изображение"] = imageString;

                driver.Quit();
                return response;
            }
            catch
            {
                driver.Quit();
                return response;
            }
        }

        public Dictionary<string, string> FetchFipsPatent(string link, string docNum)
        {
            string pattern = @"\s+";

            Dictionary<string, string> response = new Dictionary<string, string>()
            {
                { "Название", null },
                { "Номер документа", null },
                { "Автор", null },
                { "Заявитель", null },
                { "МПК", null },
                { "Реферат", null },
                { "Изображение", null },
            };

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


                var name = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/form/div/div/div[2]/div/div/p/b")).Text;
                response["Название"] = name;

                response["Номер документа"] = docNum;

                var ipc = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/form/div/div/div[2]/div/div/table[1]/tbody/tr[2]/td/table[1]/tbody/tr[2]/td[1]/div/ul/li")).Text;
                response["МПК"] = ipc;

                var text = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/form/div/div/div[2]/div/div/div[2]/p[2]")).Text;
                response["Реферат"] = text;

                var info = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/form/div/div/div[2]/div/div/table[3]/tbody/tr/td[2]")).Text;
                info = Regex.Replace(info, pattern, " ");

                var applicant = Regex.Match(info, @"Заявитель\(и\): ([^\(]+)").Value;
                response["Заявитель"] = applicant.Replace("Заявитель(и): ", "");

                var inventor = Regex.Match(info, @"Автор\(ы\): ([^\(]+)").Value;
                response["Автор"] = inventor.Replace("Автор(ы): ", "");

                IWebElement imageElement = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/form/div/div/div[2]/div/div/div[2]/p[2]/a/img"));
                string imageUrl = imageElement.GetAttribute("src");
                byte[] imageBytes = new WebClient().DownloadData(imageUrl);
                string imageString = Convert.ToBase64String(imageBytes);
                response["Изображение"] = imageString;

                driver.Quit();
                return response;
            }
            catch
            {
                driver.Quit();
                return response;
            }
        }
    }
}
