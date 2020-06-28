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
        public IWebElement EmailTextArea;

        [FindsBy(How = How.XPath, Using = "//*[@id='pass']")]
        public IWebElement UserPassArea;

        [FindsBy(How = How.XPath, Using = "//*[@id='loginbutton']")]
        public IWebElement LoginBtn;

        
        public void DisplayHomePage()
        {
            Thread.Sleep(3000);
           
            EmailTextArea.SendKeys("aryankumar01@live.com");
            UserPassArea.SendKeys("Ashish@123...123");
            LoginBtn.Click();
           
            actualTitle = driver.Title;


        }
    }
}
