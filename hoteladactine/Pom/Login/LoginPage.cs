using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace hoteladactine
{


    public class LoginPage : BaseClass
    {
       // public string Datee { get; set; }
        // public string username { get; set; }
        //public string password { get; set; }
        /* By usernamee = By.XPath("//div[text()='Select Option']"); */

        By usernamee = By.CssSelector(" form > div:nth-child(2) > div > div:nth-child(2) > input");
        By passs = By.XPath("//input[@name='password']");
        By btn = By.CssSelector(".oxd-form div:nth-child(4) button");
        By logintext = By.CssSelector(".oxd-topbar-header span h6");
        By msg = By.XPath("//p[text()='This Week']");

        public void loginn(string name, string pass)
        {
            // sendkeyy(usernamee, Datee);

            sendkeyy(usernamee,name,btn);
          // Thread.Sleep(2000);
            sendkeyy(passs, pass,btn);
           // Thread.Sleep(2000);
            click(btn,msg);
             Thread.Sleep(2000);
            //clicck and wait  
            // Thread.Sleep(2000);
            // string tes = driver.FindElement(logintext).Text;
            // Thread.Sleep(2000);
            //  Textt(msg);
            //  Assert.AreEqual("Dashboard", tes);
            // Thread.Sleep(2000);


            /*
            click(usernamee);
            Thread.Sleep(2000); */

            //Thread.Sleep(7000);
            // driver.Url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";

            // sendkeyy(usernamee, name);
            // Thread.Sleep(3000);
            //sendKey(pass,password);
            //Thread.Sleep(3000);
            //string tes = driver.FindElement(msg).Text;
            ////  Textt(msg);
            //Assert.AreEqual("Dashboards", tes);
            //Thread.Sleep(2000);

        }



    }

   
}
