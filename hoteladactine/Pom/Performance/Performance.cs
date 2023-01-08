using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace hoteladactine
{ 
    public class Performance : BaseClass
    {

        By per = By.XPath("//span[text()='Performance']");
        By usernamee = By.CssSelector("  form > div.oxd-grid-4.orangehrm-full-width-grid > div:nth-child(3) > div > div:nth-child(2) > div > div");
        By btn = By.XPath("//button[@type='submit']");


        public void performancemt()
            {

            Thread.Sleep(5000);
            click(per);
            Thread.Sleep(3000);
            click(usernamee);
            Thread.Sleep(3000);
            //input aio for keyboard instances 
            InputSimulator sim = new InputSimulator();
            sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
            sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
            sim.Keyboard.KeyPress(VirtualKeyCode.DOWN);
            sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
            Thread.Sleep(2000);
            click(btn);
            Thread.Sleep(2000);



        }







    }
}
