using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace hoteladactine
{
    public class Adminpage : BaseClass

    {
        By press = By.XPath("//span[text()='Admin']");
        By sname = By.CssSelector(".oxd-form-row div:nth-child(2) > input");
        By btn = By.CssSelector(".oxd-form-actions button:nth-child(2)");
        By check = By.CssSelector(" div.oxd-table-header > div > div:nth-child(1) > div > label > span");
        By upd = By.CssSelector(" .oxd-table-cell-actions > button:nth-child(2)");
        By dr1 = By.CssSelector(" form > div.oxd-form-row > div > div:nth-child(1) > div > div:nth-child(2) > div >div");
        By btn1=By.XPath("//button[@type='submit']");
        public void admin(string name)
        {
            
            // sendkeyy(usernamee, name);
           
            click(press);
           
            click(sname);
            
            sendkeyy(sname, name);

           
            click(btn);
            Thread.Sleep(1000);
            //java script code for scrolling 
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,document.body.scrollHeight)");
            Thread.Sleep(1000);

            click(btn);
            
            click(upd);
            
            click(dr1);
          
           // click(dr2);
            Thread.Sleep(1000);
            ///input simulator for using keyboard functions
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
           Thread.Sleep(2000);
            sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);

           Thread.Sleep(2000);
            click(btn1);
            Thread.Sleep(2000);
        }










    }
}
