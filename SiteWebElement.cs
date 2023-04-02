using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumGit2023
{
    class SiteWebElement
    {

        // ********************************************************************************** 
        // ****************************** LOGIN PAGE ELEMENTS ******************************* 
        // ********************************************************************************** 

        // Browses to Contact Us page
        public static IWebElement btnContactUs(IWebDriver driver)
        {
            IWebElement btnSubmit = driver.FindElement(By.ClassName("bannericons"));
            return btnSubmit;
        }

        // Sign up link
        public static IWebElement lnkSignUp(IWebDriver driver)
        {
            IWebElement lnkSignup = driver.FindElement(By.LinkText("Click Here"));
            return lnkSignup;
        }

        // Batman logo link
        public static IWebElement lnkLogoImage(IWebDriver driver)
        {
            IWebElement lnkLogoImage = driver.FindElement(By.CssSelector("a.navbar-brand img.logo"));
            return lnkLogoImage;
        }

        // Login screenname textfield
        public static IWebElement txtLoginScreenName(IWebDriver driver)
        {
            IWebElement txtLoginScreenName = driver.FindElement(By.Id("username"));
            return txtLoginScreenName;
        }

        // Login password textfield
        public static IWebElement txtLoginPassword(IWebDriver driver)
        {
            IWebElement txtLoginPassword = driver.FindElement(By.Id("password"));
            return txtLoginPassword;
        }

        // Login button 
        public static IWebElement btnLogin(IWebDriver driver)
        {
            IWebElement btnLogin = driver.FindElement(By.Id("button"));
            return btnLogin;
        }
                
        // Returns LOGIN page success
        public static IWebElement loginHeading(IWebDriver driver)
        {
            IWebElement loginHeading = driver.FindElement(By.ClassName("lead"));
            return loginHeading;
        }

        // ********************************************************************************** 
        // ***************************** CONTACT PAGE ELEMENTS ******************************
        // ********************************************************************************** 

        // Batman img, navigates to login when no user is logged in
        public static IWebElement imgLoginLink(IWebDriver driver)
        {
            IWebElement imgBatmanLoginLink = driver.FindElement(By.ClassName("logo"));
            return imgBatmanLoginLink;
        }

        // Returns CONTACT US page success
        public static IWebElement contactUsHeading(IWebDriver driver)
        {
            IWebElement contactUsHeading = driver.FindElement(By.XPath("//h1[text()='Contact Us']"));
            return contactUsHeading;
        }

        // ********************************************************************************** 
        // ***************************** SIGN UP PAGE ELEMENTS ******************************
        // ********************************************************************************** 

        // Returns SIGN UP page success
        public static IWebElement signUpHeading(IWebDriver driver)
        {
            IWebElement signUpHeading = driver.FindElement(By.XPath("//h5[text()='Sign up once and troll as many people as you like!']"));
            return signUpHeading;
        }

        // Text field for first name
        public static IWebElement txtFirstName(IWebDriver driver)
        {
            IWebElement txtFirstName = driver.FindElement(By.Id("firstname"));
            return txtFirstName;
        }
        
        // Span tag to display first name errors
        public static IWebElement txtFirstNameError(IWebDriver driver)
        {
            IWebElement txtFirstNameError = driver.FindElement(By.Id("firstnameError"));
            return txtFirstNameError;
        }

        // Text field for last name
        public static IWebElement txtLastName(IWebDriver driver)
        {
            IWebElement txtLastName = driver.FindElement(By.Id("lastname"));
            return txtLastName;
        }

        // Span tag to display last name errors
        public static IWebElement txtLastNameError(IWebDriver driver)
        {
            IWebElement txtLastNameError = driver.FindElement(By.Id("lastnameError"));
            return txtLastNameError;
        }

        // Text field for email
        public static IWebElement txtEmail(IWebDriver driver)
        {
            IWebElement txtEmail = driver.FindElement(By.Id("email"));
            return txtEmail;
        }

        // Span tag to display last name errors
        public static IWebElement txtEmailError(IWebDriver driver)
        {
            IWebElement txtEmailError = driver.FindElement(By.Id("emailError"));
            return txtEmailError;
        }
        // Register button
        public static IWebElement btnRegister(IWebDriver driver)
        {
            IWebElement btnRegister = driver.FindElement(By.Id("button"));
            return btnRegister;
        }

        // ********************************************************************************** 
        // ****************************** INDEX PAGE ELEMENTS *******************************
        // ********************************************************************************** 

        public static IWebElement lnkLogout(IWebDriver driver)
        {
            IWebElement lnkLogout = driver.FindElement(By.CssSelector("a[href='logout.php']"));
            return lnkLogout;
        }

        public static IWebElement imgTrumpHead(IWebDriver driver)
        {
            IWebElement imgTrumpHead = driver.FindElement(By.CssSelector("img.bannericons[src='images/profilepics/default.jfif']"));
            return imgTrumpHead;
        }
    }
}



