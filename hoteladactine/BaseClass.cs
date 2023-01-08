using AventStack.ExtentReports;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace hoteladactine
{
    public class BaseClass
    {

        public static IWebDriver driver;

        //Initializing driver here
        public static void browserinitialization()
        {
            driver = new ChromeDriver();

           
            //Thread.Sleep(3000);
            driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
            driver.Manage().Window.Maximize();
           // Thread.Sleep(12000);

        }



        //wait




        //wait close


        //Actions actions

        public void sendkeyy(By by, string data)
        {
            // driver.FindElement(by).SendKeys(data);

            try { 

            IWebElement element = WaitForElement(by);
            element.SendKeys(data);
                TakeScreenshot(Status.Pass, "PAss test");
            }

            catch 
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }

        //dusra send key haa wait krwana ka liya
        public void sendkeyy(By by, string data, By imran)
        {
            // driver.FindElement(by).SendKeys(data);

            try
            {

                IWebElement element = WaitForElement(by);
                element.SendKeys(data);
                IWebElement elementt = WaitForElement(imran);
                TakeScreenshot(Status.Pass, "PAss test");
            }

            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }




        public void click(By by)
        {
            // driver.FindElement(by).Click();
            try { 
            IWebElement element = WaitForElement(by);
                element.Click();
                TakeScreenshot(Status.Pass, "PAss test");
                
            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }

        }

        //overload cclicck function isma hum ppehla bagair wait ka click krta ha then kisi element ka wot krta hha ka wo visible ho jyee or screen shot hum lele
        //  public void click(By by, By waitelement)
        public void click(By imran,By hashmi)
        {
            // driver.FindElement(by).Click();
            try
            {
                driver.FindElement(imran).Click();
                IWebElement element = WaitForElement(hashmi);
                TakeScreenshot(Status.Pass, "PAss test");

            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");

            }
        }


            public void clear(By by)
        {
            // driver.FindElement(by).Clear();
            try { 
            IWebElement element = WaitForElement(by);
            element.Clear();
                TakeScreenshot(Status.Pass, "PAss test");
            }
            catch
            {
                TakeScreenshot(Status.Fail, "Fail test");
            }
        }





        //Extent report work////////////////////////////////
        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\Users\ImranAhsan\source\repos\hoteladactine\hoteladactine\TestExecutionReports" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            ExtentReport.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }



        public string Textt(By by)
        {
            //string text = driver.FindElement(by).Text;
            //return text;

           
             IWebElement element = WaitForElement(by);
            string text = element.Text;
            return text;
                
            
            
           
        }

        //Method for river close///////////////
        public static void TestClose()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
        ///end of method close//


        //////////////////// Code for Wait working all type of wait include Init/////////////////////////
        public IWebElement WaitForElement(By by)
        {
            IWebElement element;

            try
            {
                element = driver.FindElement(by);
            }
            catch
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
                wait.Until(driver => IsPageReady(driver) == true && IsElementVisible(by) == true);
                element = driver.FindElement(by);
            }

            return element;


        }
        private bool IsPageReady(IWebDriver driver)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete");
        }

        private bool IsElementVisible(By by)
        {
            if (driver.FindElement(by).Enabled || driver.FindElement(by).Displayed == true)
                return true;

            else
                return false;
        }
        ///////////////////////////// End of wait code //////////////////////////////



    }
}