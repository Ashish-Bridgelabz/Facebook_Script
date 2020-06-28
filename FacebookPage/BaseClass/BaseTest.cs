using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FacebookPage.FacebookLoginData
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void OpenApplication()
        {
            ChromeOptions Options = new ChromeOptions( );
            Options.AddArguments("--disable-notifications");

            driver = new ChromeDriver(Options);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebook.com/";
        }

        [Test]
        public void LoginTest()
        {
            FacebookLoginData data = new FacebookLoginData(driver);
            data.DisplayHomePage();
        }

        [Test]
        public void Update()
        {
            ArticlePost post = new ArticlePost(driver);
            post.DisplayTOArticlePost();
        }
       
        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(50000);
            driver.Quit();
        }

        

        
    }
}

