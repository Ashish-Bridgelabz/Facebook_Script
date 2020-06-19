using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FacebookPage.FacebookLoginData
{
    public class FacebookLoginData
    {
        public IWebDriver driver;
        public string actualTitle;
        public FacebookLoginData(IWebDriver driver)
        {
            this.driver = driver;
            //INITIALIZING ALL THE WEBELEMENTS// 
            PageFactory.InitElements(driver, this);
        }
        //IDENTIFY THE PARICULAR ELEMENTS//
        [FindsBy(How = How.XPath, Using = "//*[@id='email']")]
        public IWebElement EmailTextArea { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='pass']")]
        public IWebElement UserPassArea { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='loginbutton']")]
        public IWebElement LoginBtn { get; set; }

        public void DisplayHomePage()
        {
            Thread.Sleep(3000);
           
            EmailTextArea.SendKeys("aryankumar01@live.com");
            UserPassArea.SendKeys("Asish@.");
            LoginBtn.Click();
            actualTitle = driver.Title;


        }
    }
}
