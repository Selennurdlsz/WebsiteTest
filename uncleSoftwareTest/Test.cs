using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace uncleSoftwareTest
{
    [TestFixture]
    public class Test
    {
        IWebDriver driver = new ChromeDriver(); // tarayıcımızı driver nesnesine atadık
        [Test]
        public void siteninAcilmesi()
        {
            
            driver.Navigate().GoToUrl("http://unclesoftware.com/"); // tarayıcımızın gitmesi gerektiği sitenin urlsini verdik 
            Assert.Pass("sitenin açılması passing test");
        }
        [Test]
        public void ilanOlustur()
         {
             driver.Navigate().GoToUrl("http://unclesoftware.com/");// tarayıcımızın gitmesi gerektiği site

             driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
             System.Threading.Thread.Sleep(2000);
             driver.FindElement(By.Name("emailorname")).SendKeys("mine1213@gmail.com"); // burada kullanıcı adı veya eposta ile giriş için bilgiler gönderiliyor textboxa
             System.Threading.Thread.Sleep(2000);
             driver.FindElement(By.Name("password")).SendKeys("mine12345"); // burada kullanıcı şifresi gönderilyor textboxa
             System.Threading.Thread.Sleep(2000);
             driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click(); // burada ise giriş yapma butonuna tıklanıyor
             System.Threading.Thread.Sleep(2000);
             driver.FindElement(By.CssSelector("#navigation-index > ul > li:nth-child(6)")).Click();
             System.Threading.Thread.Sleep(2000);
             driver.FindElement(By.XPath("//*[@id='navigation-index']/ul/li[6]/ul/li[3]/a ")).Click();
             System.Threading.Thread.Sleep(2000);
             driver.FindElement(By.Name("position")).SendKeys("Yazılım Mühendisi");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("departmant")).SendKeys("Bilişim");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("email")).SendKeys("anonimbilisim@gmail.com");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("phone")).SendKeys("5324561232");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("country")).SendKeys("Türkiye");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("citytype")).SendKeys("Izmir");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("district")).SendKeys("Karsiyaka");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#btn-job-next")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.XPath("//*[@id='jobForm']/div[2]/div[1]/div/div/label/span")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#btn-job-next")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#frontEnd-skills-list > div.col-md-6.right-div-6 > div:nth-child(1) ")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#backEnd-skills-list > div:nth-child(1) > div:nth-child(2)")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#backEnd-skills-list > div:nth-child(1) > div:nth-child(6)")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#framework-skills-list > div:nth-child(1) > div:nth-child(3) ")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#db-skills-list > div:nth-child(1) > div:nth-child(2)")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#db-skills-list > div:nth-child(1) > div:nth-child(3)")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#ide-skills-list > div:nth-child(1) > div:nth-child(5) ")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#desing-skills-list > div > div.checkbox.select-all-check-box ")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#server-skills-list > div > div:nth-child(4) ")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#metod-skills-list > div.col-md-6.right-div-6 > div:nth-child(4)")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#metod-skills-list > div:nth-child(1) > div:nth-child(7) ")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#btn-job-next")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("jobdescription")).SendKeys("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("jobfeature")).SendKeys("xxxxxxxxxxxxxxxxxxxx");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#job-language-choice > div:nth-child(1) > div:nth-child(10)")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#job-language-choice > div:nth-child(1) > div:nth-child(20)")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#submit-job-form-button > button")).Click();
             System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#navigation-index > ul > li:nth-child(6)")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='doLogOut']")).Click();
            System.Threading.Thread.Sleep(3000);
            Assert.Pass("ilan oluşturma passing test");
         }
        [Test]
        public void ilanAra()
        {
            driver.Navigate().GoToUrl("http://unclesoftware.com/");// tarayıcımızın gitmesi gerektiği site

            driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/ul/li[2]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("emailorname")).SendKeys("selen123@gmail.com"); // burada kullanıcı adı veya eposta ile giriş için bilgiler gönderiliyor textboxa
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.Name("password")).SendKeys("selen12345"); // burada kullanıcı şifresi gönderilyor textboxa
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click(); 
            System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.CssSelector("#search-job-btn > span")).Click();
             System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[1]/div/div/button/span[1]")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[1]/div/div/div/ul/li[90]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[2]/div/div/button")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.XPath("/html/body/nav/div/div[3]/form/div[2]/div/div/div/ul/li[35]/a")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#search-job-form-btn")).Click();
            System.Threading.Thread.Sleep(3000);
            driver.FindElement(By.CssSelector("#navigation-index > ul > li:nth-child(7)")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='doLogOut']")).Click();
            System.Threading.Thread.Sleep(3000);

            Assert.Pass("İlan arama passing test");

        }
        [Test]

         public void KurumsalKayitOlma()
         {
             driver.Navigate().GoToUrl("http://unclesoftware.com/");
             driver.FindElement(By.XPath("/ html / body / div[1] / div / div[1] / ul / li[1] / a")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("name")).SendKeys("Mine Yaman");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("mail")).SendKeys("mine1256@gmail.com");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("password")).SendKeys("mine1234");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.XPath("//*[@id='signupForm']/div[2]/div[4]/label[2]")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/div[3]/a")).Click();
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("nick")).SendKeys("Mine1245");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("phoneUser")).SendKeys("5327134152");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("companyName")).SendKeys("Anonim Bilişim");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("phoneCompany")).SendKeys("5239654785");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("companyDate")).SendKeys("2005-12-25");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("companyMail")).SendKeys("anonimbilisim@gmail.com");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("companyWeb")).SendKeys("www.anonimBilisim.com");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.Name("companyAbout")).SendKeys("Anonim Bilişim  2005 yılında kurulmuştur.");
             System.Threading.Thread.Sleep(3000);
             driver.FindElement(By.XPath("//*[@id='welcomeCForm']/div[2]/a")).Click();
             Assert.Pass("Kurumsal kayit olma passing test");
         }
        









    }
}
