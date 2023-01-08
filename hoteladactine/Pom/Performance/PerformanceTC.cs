using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoteladactine
{
    [TestClass]
    public class LoginTCPerformanceTC
    {
        [ClassCleanup]// ya tag sub sa end ma chulta ha humari execution ka 
        public static void TestClose()
        {
            BaseClass.driver.Quit();
        }



        private TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        //For the driver 
        [ClassInitialize] //ya tag sub sa pehla chulta ha jub humari execution statrrt hoti ha tb
        public static void ClassInit(TestContext context) //(TestContext context)
        {
            BaseClass.browserinitialization();

        }


        // ya extent report ka liya ha or ya test initialize har test method sa pehla run hota ha 
        [TestInitialize]
        public void TestInit()
        {
            ExtentReport.LogReport(TestContext.TestName);
            ExtentReport.exParentTest = ExtentReport.extentReports.CreateTest(TestContext.TestName);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            ExtentReport.extentReports.Flush();

        }

        [TestMethod]
        public void Performance()
        {
            ExtentReport.exChildTest = ExtentReport.exParentTest.CreateNode("lOGIN");
            LoginPage pagee = new LoginPage();
            pagee.loginn("Admin", "admin123");


            Performance page = new Performance();
            page.performancemt();

        }






    }
}
