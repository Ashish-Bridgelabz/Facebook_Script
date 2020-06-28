using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace FacebookPage.FacebookLoginData
{
    public class ArticlePost
    {
        IWebDriver driver;
        public ArticlePost(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//textarea[@name = 'xhpc_message']")] 
        public IWebElement StatusTextArea;
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'_1mf _1mj')]")]
        public IWebElement TextBoxArea;
        [FindsBy(How = How.XPath, Using = "//span[@class='l3itjdph cga1ltu']")]
        public IWebElement PrivacyOnlyForMe;
        [FindsBy(How = How.XPath, Using = "//div[@class = '_45wg _69yt']")]
        public IWebElement PostBtn;
        [FindsBy(How=How.XPath,Using = "//div[@class = '_3jk']")]
        public IWebElement photoBtn;
        [FindsBy(How = How.XPath, Using = "//div[@id = 'userNavigationLabel']")]
        public IWebElement AccountSettings;
        [FindsBy(How = How.XPath, Using = "//li[@class = '_54ni navSubmenu _6398 _64kz __MenuItem']")]
        public IWebElement LogoutBtn;   

        public void DisplayTOArticlePost()
        {
           StatusTextArea.Click();
           Thread.Sleep(1500);
           StatusTextArea.SendKeys("Hello There");
           Thread.Sleep(5000);
           photoBtn.Click();
           Thread.Sleep(4000);
           Process.Start("C:\\Users\\Dell\\Desktop\\AutoIT\\FileUpload.exe");
           Thread.Sleep(10000);
           PostBtn.Click();
           Thread.Sleep(4000);
           AccountSettings.Click();
           Thread.Sleep(4000);
           LogoutBtn.Click();
        }
    }
}
    

