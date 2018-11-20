using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestClass]
    public class Test1
    {
        private static IWebDriver driver;
        private StringBuilder verificationErrors;
        private static string baseURL;
        private bool acceptNextAlert = true;

        [ClassInitialize]
        public static void InitializeClass(TestContext testContext)
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.katalon.com/";
        }

        [ClassCleanup]
        public static void CleanupClass()
        {
            try
            {
                //driver.Quit();// quit does not close the window
                driver.Close();
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        [TestInitialize]
        public void InitializeTest()
        {
            verificationErrors = new StringBuilder();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [TestMethod]
        public void The1Test()
        {
            driver.Navigate().GoToUrl("https://www.tinkoff.ru/");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вклады'])[5]/following::a[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Мобильная связь'])[2]/following::div[8]")).Click();

            if(driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='ЖКУ-Москва'])[1]/preceding::span[3]")).Text != "Москве")
            {
                driver.Navigate().GoToUrl("https://www.tinkoff.ru/payments/categories/kommunalnie-platezhi/");
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='ВЦКП «Жилищное хозяйство»'])[1]/preceding::span[3]")).Click();
                driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Поиск'])[1]/following::span[4]")).Click();
            }

            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Москве'])[1]/following::div[11]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Узнать задолженность за ЖКУ в Москве'])[1]/following::span[1]")).Click();
            driver.FindElement(By.Id("payerCode")).Clear();
            driver.FindElement(By.Id("payerCode")).SendKeys("1234567891");
            driver.FindElement(By.Id("payerCode")).Click();
            driver.FindElement(By.Id("payerCode")).Clear();
            driver.FindElement(By.Id("payerCode")).SendKeys("");
            try
            {
                Assert.AreEqual("Введите 10-значный код плательщика за жилищно-коммунальные услуги", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Код плательщика за ЖКУ в Москве'])[1]/following::span[4]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Поле обязательное", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Введите 10-значный код плательщика за жилищно-коммунальные услуги'])[1]/following::div[1]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Оплатить ЖКУ в Москве'])[1]/following::div[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Оплатить ЖКУ в Москве'])[1]/following::div[2]")).Click();
            try
            {
                Assert.AreEqual("Введите оплачиваемый период", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='За какой период оплачиваете коммунальные услуги'])[1]/following::span[5]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.CssSelector("span.ui-icon.ui-icon_border.ui-icon_color_another.ui-input__calendar-icon > svg.ui-icon__svg-wrapper > path.ui-icon__svg")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Выберите дату'])[1]/following::span[1]")).Click();
            driver.FindElement(By.CssSelector("span.ui-icon.ui-icon_border.ui-icon_color_another.ui-input__calendar-icon > svg.ui-icon__svg-wrapper > path.ui-icon__svg")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='ФЕВ'])[1]/following::span[1]")).Click();
            driver.FindElement(By.Id("period")).Clear();
            driver.FindElement(By.Id("period")).SendKeys("03.2040");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Click();
            driver.FindElement(By.Id("period")).Click();
            driver.FindElement(By.Id("period")).Clear();
            driver.FindElement(By.Id("period")).SendKeys("20.2040");
            try
            {
                Assert.AreEqual("Поле заполнено некорректно", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Введите оплачиваемый период'])[1]/following::div[2]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).SendKeys("-500");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Коммунальные платежи'])[1]/following::div[9]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::div[6]")).Click();
            try
            {
                Assert.AreEqual("Поле заполнено неверно", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::div[6]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::input[1]")).SendKeys("");
            try
            {
                Assert.AreEqual("В поле ввода суммы платежа необходимо указывать итоговую сумму, включающую добровольное страхование.", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Коммунальные платежи'])[1]/following::div[14]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма платежа, ₽'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма платежа, ₽'])[1]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма платежа, ₽'])[1]/following::input[1]")).SendKeys("-500");
            try
            {
                Assert.AreEqual("Сумма добровольного страхования не может быть больше итоговой суммы.", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::div[6]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Поле заполнено неверно", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма платежа, ₽'])[1]/following::div[6]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            try
            {
                Assert.AreEqual("Вы можете посчитать сумму прямо в поле. Например, введите 300+250+500. Cумма в формате 00,00.", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Коммунальные платежи'])[1]/following::div[14]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Оплатить ЖКУ в Москве'])[2]/following::div[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вклады'])[4]/following::a[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вклады'])[4]/following::a[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='-'])[3]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='-'])[3]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='-'])[3]/following::input[1]")).SendKeys("ЖКУ-Москва");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='-'])[3]/following::div[23]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Узнать задолженность за ЖКУ в Москве'])[1]/following::span[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Коммунальные платежи'])[1]/following::div[9]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Сумма добровольного страхования жилья из квитанции за ЖКУ в Москве, ₽'])[1]/following::div[23]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Оплатите ЖКУ в Москве без комиссии'])[1]/following::div[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Вклады'])[4]/following::a[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Мобильная связь'])[2]/following::div[8]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='ЖКУ-Москва'])[1]/preceding::span[3]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='г. Москва'])[1]/following::span[2]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::input[1]")).SendKeys("ЖКУ");
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::input[1]")).Click();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::input[1]")).Clear();
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::input[1]")).SendKeys("ЖКУ-Москва");
            try
            {
                Assert.AreEqual("Ничего не найдено", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Санкт-Петербурге'])[1]/following::div[18]")).Text);
            }
            catch (Exception e)
            {
                verificationErrors.Append(e.Message);
            }
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Банкоматы'])[2]/following::div[5]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
