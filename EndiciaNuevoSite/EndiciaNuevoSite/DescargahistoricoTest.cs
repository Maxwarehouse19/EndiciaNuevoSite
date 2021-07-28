// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using System.Configuration;
using System.Globalization;


[TestFixture]
public class DescargahistoricoTest {
    private IWebDriver driver;
    public IDictionary<string, object> vars {get; private set;}
    private IJavaScriptExecutor js;

    [SetUp]
    public void SetUp() {
        ChromeOptions options = new ChromeOptions();
        string Cookies = @"user-data-dir=" + ConfigurationManager.AppSettings["PathCookies"];
        options.AddArguments(Cookies);//specify location for profile creation/ access
                                        //ChromeDriver driver = new ChromeDriver(options);

        String downloadFilepath = ConfigurationManager.AppSettings["RutaDescarga"];
        options.AddUserProfilePreference("download.prompt_for_download", false);
        options.AddUserProfilePreference("download.directory_upgrade", true);
        options.AddUserProfilePreference("download.default_directory", downloadFilepath);

        driver = new ChromeDriver(options);
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }

    [TearDown]
    protected void TearDown() {
    driver.Quit();
    }
    
    [Test]
    public void descargahistorico() {
        // Test name: descargahistorico
        // Step # | name | target | value
        // 1 | open | /SignIn/?env=ReportsBalances&IsInStore=1 | 
        driver.Navigate().GoToUrl("https://print.endicia.com/SignIn/?env=ReportsBalances&IsInStore=1");

        System.Threading.Thread.Sleep(30000);

        // 2 | setWindowSize | 1075x824 | 
        driver.Manage().Window.Size = new System.Drawing.Size(1075, 824);
        // 3 | click | id=textfield-1021-inputEl | 
        driver.FindElement(By.Id("textfield-1021-inputEl")).Click();
        driver.FindElement(By.Id("textfield-1021-inputEl")).Clear();
        driver.FindElement(By.Id("textfield-1021-inputEl")).SendKeys("955633");

        System.Threading.Thread.Sleep(5000);

        // 4 | type | id=textfield-1024-inputEl | Verita1234.
        driver.FindElement(By.Id("textfield-1024-inputEl")).Click();
        driver.FindElement(By.Id("textfield-1024-inputEl")).Clear();
        driver.FindElement(By.Id("textfield-1024-inputEl")).SendKeys("Verita1234.");

        System.Threading.Thread.Sleep(15000);

        // 5 | click | id=button-1029-btnInnerEl | 
        driver.FindElement(By.Id("button-1029-btnInnerEl")).Click();

        System.Threading.Thread.Sleep(30000);

        // 6 | click | css=.dropdown-toggle:nth-child(2) | 
        driver.FindElement(By.CssSelector(".dropdown-toggle:nth-child(2)")).Click();

        System.Threading.Thread.Sleep(60000);
        // 7 | click | css=#badgebutton-1069 .sdc-badgebutton-text | 
        driver.FindElement(By.CssSelector("#badgebutton-1069 .sdc-badgebutton-text")).Click();

        System.Threading.Thread.Sleep(60000);
        // 8 | click | id=toolbarbutton-1044-btnIconEl | 
        driver.FindElement(By.Id("toolbarbutton-1044-btnIconEl")).Click();

    }
}
