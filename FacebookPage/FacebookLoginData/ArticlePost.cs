using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
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

       /* [FindsBy(How = How.XPath, Using = "//div[@class='m9osqain a5q79mjw']")]
        public IWebElement StatusTextArea;//div[@class='m9osqain a5q79mjw']
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'arkytfgfuyf')]")]
        public IWebElement TextBoxArea;
        [FindsBy(How = How.XPath, Using = "//span[@class='l3itjdph cga1ltu']")]
        public IWebElement PrivacyOnlyForMe;
        [FindsBy(How = How.XPath, Using = "//div[@class='oajrlxb2 s1i5eluu qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 pq6dq46d p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x cxgpxx05 d1544ag0 sj5x9vvc tw6a2znq oqcyycmt esuyzwwr f1sip0of lzcic4wl l9j0dhe7 abiwlrkh p8dawk7l ehryuci6 bp9cbjyn beltcj47 p86d2i9g aot14ch1 kzx2olss rt8b4zig n8ej3o3l agehan2d sk4xxmp2 lrazzd5p gigivrx4 sf5mxxl7 g0qnabr5 lrwzeq9o iqfcb0g7 lsqurvkf id6903cd jq4qci2q m5l1wtfr taijpn5t sn7ne77z oqhjfihn bwm1u5wc']")]
        public IWebElement PostBtn;*/


        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Feeling')]")]
        public IWebElement FeelingActicityBtn;

        [FindsBy(How = How.CssSelector, Using = "#35 28297480516636 > div > div > div > div.hpfvmrgz.g5gj957u.buofh1pr.rj1gh0hx.o8rfisnq")]
        public IWebElement Happy;

        [FindsBy(How = How.XPath, Using = "//div[@class='oajrlxb2 s1i5eluu qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 pq6dq46d p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x cxgpxx05 d1544ag0 sj5x9vvc tw6a2znq oqcyycmt esuyzwwr f1sip0of lzcic4wl l9j0dhe7 abiwlrkh p8dawk7l ehryuci6 bp9cbjyn beltcj47 p86d2i9g aot14ch1 kzx2olss rt8b4zig n8ej3o3l agehan2d sk4xxmp2 lrazzd5p gigivrx4 sf5mxxl7 g0qnabr5 lrwzeq9o iqfcb0g7 lsqurvkf id6903cd jq4qci2q m5l1wtfr taijpn5t sn7ne77z oqhjfihn bwm1u5wc']")]
        public IWebElement PostBtn;
        //*[@id=\"js_6m\"]/div[2]/div[3]/div[2]/button/span"

        public void DisplayTOArticlePost()
        {
            Thread.Sleep(3000);
            FeelingActicityBtn.Click();
            Thread.Sleep(3000);
            Happy.Click(); 
            Thread.Sleep(3000);
            PostBtn.Click();
           
           /* StatusTextArea.Click();
            Thread.Sleep(2000);
            
            TextBoxArea.SendKeys("Hello Facebook");
            Thread.Sleep(2000);            
           // PrivacyOnlyForMe.Click();
            PostBtn.Click();*/
        }
    }
}
    

