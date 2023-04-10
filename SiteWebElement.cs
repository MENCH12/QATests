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

        // Span tag to display email errors
        public static IWebElement txtEmailError(IWebDriver driver)
        {
            IWebElement txtEmailError = driver.FindElement(By.Id("emailError"));
            return txtEmailError;
        }

        // Text field for Screen Name
        public static IWebElement txtSname(IWebDriver driver)
        {
            IWebElement txtSname = driver.FindElement(By.Id("username"));
            return txtSname;
        }

        // Span tag to display Screen Name errors
        public static IWebElement txtSnameError(IWebDriver driver)
        {
            IWebElement txtSnameError = driver.FindElement(By.Id("usernameError"));
            return txtSnameError;
        }

        // Text field for Password
        public static IWebElement txtPassword(IWebDriver driver)
        {
            IWebElement txtPassword = driver.FindElement(By.Id("password"));
            return txtPassword;
        }

        // Span tag to display Password errors
        public static IWebElement txtPasswordError(IWebDriver driver)
        {
            IWebElement txtPasswordError = driver.FindElement(By.Id("passwordError"));
            return txtPasswordError;
        }

        // Text field for Confirm Password
        public static IWebElement txtCpassword(IWebDriver driver)
        {
            IWebElement txtCpassword = driver.FindElement(By.Id("confirm"));
            return txtCpassword;
        }

        // Span tag to display Confirm Password errors
        public static IWebElement txtCpasswordError(IWebDriver driver)
        {
            IWebElement txtCpasswordError = driver.FindElement(By.Id("confirmError"));
            return txtCpasswordError;
        }

        // Text field for Phone Number
        public static IWebElement txtPnum(IWebDriver driver)
        {
            IWebElement txtPnum = driver.FindElement(By.Id("phone"));
            return txtPnum;
        }

        // Span tag to display Phone Number errors
        public static IWebElement txtPnumError(IWebDriver driver)
        {
            IWebElement txtPnumError = driver.FindElement(By.Id("phoneError"));
            return txtPnumError;
        }

        // Text field for Address
        public static IWebElement txtAddress(IWebDriver driver)
        {
            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            return txtAddress;
        }

        // Span tag to display Address errors
        public static IWebElement txtAddressError(IWebDriver driver)
        {
            IWebElement txtAddressError = driver.FindElement(By.Id("addressError"));
            return txtAddressError;
        }

        // Text field for Postal Code
        public static IWebElement txtPcode(IWebDriver driver)
        {
            IWebElement txtPcode = driver.FindElement(By.Id("postalCode"));
            return txtPcode;
        }

        // Span tag to display Postal Code errors
        public static IWebElement txtPcodeError(IWebDriver driver)
        {
            IWebElement txtPcodeError = driver.FindElement(By.Id("postalCodeError"));
            return txtPcodeError;
        }

        // Text field for URL
        public static IWebElement txtURL(IWebDriver driver)
        {
            IWebElement txtURL = driver.FindElement(By.Id("url"));
            return txtURL;
        }

        // Text field for Description
        public static IWebElement txtDescript(IWebDriver driver)
        {
            IWebElement txtDescript = driver.FindElement(By.Id("desc"));
            return txtDescript;
        }

        // Span tag to display Description errors
        public static IWebElement txtDescError(IWebDriver driver)
        {
            IWebElement txtDescError = driver.FindElement(By.Id("descError"));
            return txtDescError;
        }

        // Text field for Location
        public static IWebElement txtLocation(IWebDriver driver)
        {
            IWebElement txtLocation = driver.FindElement(By.Id("location"));
            return txtLocation;
        }

        // Text field for Province Selector
        public static IWebElement txtProvince(IWebDriver driver)
        {
            IWebElement txtProvince = driver.FindElement(By.Id("province"));
            return txtProvince;
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



