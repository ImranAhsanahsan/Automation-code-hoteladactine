using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoteladactine
{

    [TestClass]
    public class AdminpageTC
    { 



        [ClassCleanup]// ya tag sub sa end ma chulta ha humari execution ka 
        public static void TestClosee()
        {
            BaseClass.driver.Quit();
        }

        private TestContext instancee;
        public TestContext TestContext
        {
            set { instancee = value; }
            get { return instancee; }
        }
        //For the driver 
        [ClassInitialize] //ya tag sub sa pehla chulta ha jub humari execution statrrt hoti ha tb
        public static void ClassInitt(TestContext context) //(TestContext context)
        {
            BaseClass.browserinitialization();
            

        }


        // ya extent report ka liya ha or ya test initialize har test method sa pehla run hota ha 
        [AssemblyInitialize]
        public void TestInit()
        {
            ExtentReport.LogReport(TestContext.TestName);
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
        }

        [AssemblyCleanup]
        public void TestCleanup()
        {
            ExtentReport.extentReports.Flush();

        }





        [TestMethod]
        public void Adminn()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("Admin Page");

            LoginPage page = new LoginPage();
            page.loginn("Admin", "admin123");

            


            Adminpage Apage = new Adminpage();
                Apage.admin("Admin");


        }
    }
}