using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace SeleniumGit2023
{
    class SiteTest
    {
        // ********************************************************************************** 
        // ************************************* TESTS ************************************** 
        // **********************************************************************************

        // ***************************************************************************************************
        // ********************************************************************************** LOGIN page tests
        // ***************************************************************************************************

        // Contact Us button on LOGIN leads to CONTACT US page
        public static bool ContactButtonTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the login page an submit them
                LoginPage(driver, true, false, "", "", false);

                // Get the success message Web Element
                IWebElement contactUsHeading = SiteWebElement.contactUsHeading(driver);

                // Get the text from the success message Web Element
                String strSuccess = contactUsHeading.Text;

                // Test if the text conatins what we expect on as successful login
                if (strSuccess.Contains("Contact Us"))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }

        }
                
        // Sign Up link on LOGIN leads to SIGN UP page
        public static bool SignUpLinkTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the login page an submit them
                LoginPage(driver, false, true, "", "", false);

                // Get the success message Web Element
                IWebElement signUpHeading = SiteWebElement.signUpHeading(driver);

                // Get the text from the success message Web Element
                String strSuccess = signUpHeading.Text;

                // Test if the text conatins what we expect on as successful login
                if (strSuccess.Contains("Sign up once and troll as many people as you like!"))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }

        }

        // Invalid user and password signin
        public static bool InvalidSignInTest(IWebDriver driver)
        {
            LoginPage(driver, false, false, "BadScreenName", "WorsePassword", true);

            Thread.Sleep(100);

            // Get the current URL of the browser window
            string currentUrl = driver.Url;

            // Compare the current URL with the expected URL
            if (currentUrl != "http://10.157.123.12/site4/index.php")
            {
                // Test was successful
                return true;
            }
            else
            {
                // Test was NOT successful
                return false;
            }
        }

        // Valid user and password signin
        public static bool ValidSignInTest(IWebDriver driver)
        {
            LoginPage(driver, false, false, "Test", "asdf", true);

            Thread.Sleep(100);

            // Get the current URL of the browser window
            string currentUrl = driver.Url;

            // Compare the current URL with the expected URL
            if (currentUrl == "http://10.157.123.12/site4/index.php")
            {
                // Test was successful
                return true;
            }
            else
            {
                // Test was NOT successful
                return false;
            }
        }

        // ********************************************************************************************************
        // ********************************************************************************** CONTACT US page tests
        // ********************************************************************************************************

        // Batman image button on CONTACT US leads to LOGIN page
        public static bool BatmanLoginNavTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the login page an submit them
                ContactUsPage(driver, true);

                // Get the success message Web Element
                IWebElement loginHeading = SiteWebElement.loginHeading(driver);

                // Get the text from the success message Web Element
                String strSuccess = loginHeading.Text;

                // Test if the text conatins what we expect on as successful login
                if (strSuccess.Contains("Bitter - Social Media for Trolls, Narcissists, Bullies and United States Presidents."))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }

        }

        // ********************************************************************************************************
        // ************************************************************************************* SIGN UP page tests
        // ********************************************************************************************************

        // Blank first name field
        public static bool BlankFirstNameTest(IWebDriver driver)
        {
            Logout(driver, true);

            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "", "", "");

                // Get the success message Web Element
                IWebElement txtFirstNameError = SiteWebElement.txtFirstNameError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtFirstNameError.Text;

                // Test if the text contains what we expect on as unsuccessful sign up
                if (strSuccess.Contains("This is a required field."))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // First name field over 50 characters
        public static bool FirstNameOver50CharsTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedc", "", "");

                // Get the success message Web Element
                IWebElement txtFirstNameError = SiteWebElement.txtFirstNameError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtFirstNameError.Text;

                // Test if the text contains what we expect on as unsuccessful sign up
                if (strSuccess.Contains("First name cannot be longer than 50 characters."))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Acceptable first name field
        public static bool FirstNameAcceptableTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "", "");

                // Get the success message Web Element
                IWebElement txtFirstNameError = SiteWebElement.txtFirstNameError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtFirstNameError.Text;

                // Test if the text contains what we expect on as successful sign up
                if (strSuccess.Contains(""))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Blank last name field
        public static bool BlankLastNameTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "", "");

                // Get the success message Web Element
                IWebElement txtLastNameError = SiteWebElement.txtLastNameError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtLastNameError.Text;

                // Test if the text contains what we expect on as unsuccessful sign up
                if (strSuccess.Contains("This is a required field."))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Last name field over 50 characters
        public static bool LastNameOver50CharsTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedc", "");

                // Get the success message Web Element
                IWebElement txtLastNameError = SiteWebElement.txtLastNameError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtLastNameError.Text;

                // Test if the text contains what we expect on as unsuccessful sign up
                if (strSuccess.Contains("Last name cannot be longer than 50 characters."))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Acceptable last name field
        public static bool LastNameAcceptableTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "Goodname", "");

                // Get the success message Web Element
                IWebElement txtLastNameError = SiteWebElement.txtLastNameError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtLastNameError.Text;

                // Test if the text contains what we expect on as successful sign up
                if (strSuccess.Contains(""))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Blank email field
        public static bool BlankEmailTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "", "");

                // Get the success message Web Element
                IWebElement txtEmailError = SiteWebElement.txtEmailError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtEmailError.Text;

                // Test if the text contains what we expect on as unsuccessful sign up
                if (strSuccess.Contains("This is a required field."))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Non-email address in email field
        public static bool BadEmailAddressTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "Goodname", "Bademail");

                // Get the success message Web Element
                IWebElement txtEmailError = SiteWebElement.txtEmailError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtEmailError.Text;

                // Test if the text contains what we expect on as unsuccessful sign up
                if (strSuccess.Contains("That is not a valid email address. Example: example@example.com"))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Email field over 100 characters
        public static bool EmailOver100CharsTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "Goodman", "qazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolptgbyhnujmikolpqazwsxedcrfvtgbyhnujmikolp");

                // Get the success message Web Element
                IWebElement txtEmailError = SiteWebElement.txtEmailError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtEmailError.Text;

                // Test if the text contains what we expect on as unsuccessful sign up
                if (strSuccess.Contains("Email cannot be longer than 100 characters."))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Acceptable last name field
        public static bool EmailAcceptableTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "Goodname", "example@example.com");

                // Get the success message Web Element
                IWebElement txtEmailError = SiteWebElement.txtEmailError(driver);

                // Get the text from the success message Web Element
                String strSuccess = txtEmailError.Text;

                // Test if the text contains what we expect on as successful sign up
                if (strSuccess.Contains(""))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Does the form submit when populated with valid info?
        public static bool FormSubmitTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "Goodname", "example@example.com", "XxexamplexX", "1234567", "1234567", "111-2222-3456",
                    "111 example St.",  "E3A 0A1", "example");

                // Get the success message Web Element
                IWebElement accountSucc = SiteWebElement.accountSucc(driver);

                // Get the text from the success message Web Element
                String strSuccess = accountSucc.Text;

                // Test if the text contains what we expect on as successful sign up
                if (strSuccess.Contains("Your account has been created!"))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // Does the form submit with passwords that don't match?
        public static bool CpasswordTest(IWebDriver driver)
        {
            try
            {
                // Enter the following information into the sign up page an submit them
                SignUpPage(driver, true, "Goodname", "Goodname", "example@example.com", "XxexamplexX", "1234567", "1234568", "111-2222-3456",
                    "111 example St.", "E3A 0A1", "example");

                // Get the success message Web Element
                IWebElement accountSucc = SiteWebElement.accountSucc(driver);

                // Get the text from the success message Web Element
                String strSuccess = accountSucc.Text;

                // Test if the text contains what we expect on as successful sign up
                if (strSuccess.Contains("Your account has been created!"))
                {
                    // Test was successful
                    return true;
                }
                else
                {
                    // Test was NOT successful
                    return false;
                }

            }
            catch (Exception ex)
            {
                // Test was not successful. Crashed somewhere
                return false;
            }
        }

        // ********************************************************************************** 
        // ********************************* PAGE DRIVERS *********************************** 
        // ********************************************************************************** 

        public static void LoginPage(IWebDriver driver, bool lnkContactUsBool, bool lnkSignUpBool, string strLoginScreenName, string strLoginPassword, bool btnLoginBool)
        {
            // Get elements for the page
            //driver.Navigate().GoToUrl("http://10.157.123.12/site4/login.php");
            driver.Url = "http://10.157.123.12/site4/login.php";

            IWebElement btnLogin = SiteWebElement.btnLogin(driver);  
            IWebElement btnContactUs = SiteWebElement.btnContactUs(driver);
            IWebElement lnkSignUp = SiteWebElement.lnkSignUp(driver);
            IWebElement txtLoginScreenName = SiteWebElement.txtLoginScreenName(driver);
            IWebElement txtLoginPassword = SiteWebElement.txtLoginPassword(driver);

            txtLoginScreenName.SendKeys(strLoginScreenName);
            txtLoginPassword.SendKeys(strLoginPassword);

            if (btnLoginBool)
            {
                btnLogin.Click();
            }
            if (lnkContactUsBool)
            {
                btnContactUs.Click();
            }
            if (lnkSignUpBool)
            {
                lnkSignUp.Click();
            }
        }

        public static void ContactUsPage(IWebDriver driver, bool lnkLoginImg)
        {
            // Get elements for the page
            driver.Url = "http://10.157.123.12/site4/ContactUs.php";

            IWebElement imgBatmanLoginLink = SiteWebElement.imgLoginLink(driver);

            if (lnkLoginImg)
            {
                imgBatmanLoginLink.Click();
            }

        }

        public static void SignUpPage(IWebDriver driver, bool btnRegisterBool, string strFirstName, string strLastName, string strEmail, string strSname,
           string strPassword, string strCpassword, string strPnum, string strAddress, string strPcode, string strDescript)
        {
            // Get elements for the page
            driver.Url = "http://10.157.123.12/site4/signup.php";

            IWebElement btnRegister = SiteWebElement.btnRegister(driver);
            IWebElement txtFirstName = SiteWebElement.txtFirstName(driver);
            IWebElement txtLastName = SiteWebElement.txtLastName(driver);
            IWebElement txtEmail = SiteWebElement.txtEmail(driver);
            IWebElement txtSname = SiteWebElement.txtSname(driver);
            IWebElement txtPassword = SiteWebElement.txtPassword(driver);
            IWebElement txtCpassword = SiteWebElement.txtCpassword(driver);
            IWebElement txtPnum = SiteWebElement.txtPnum(driver);
            IWebElement txtAddress = SiteWebElement.txtAddress(driver);
            IWebElement txtPcode = SiteWebElement.txtPcode(driver);
            IWebElement txtDescript = SiteWebElement.txtDescript(driver);

            txtFirstName.SendKeys(strFirstName);
            txtLastName.SendKeys(strLastName);
            txtEmail.SendKeys(strEmail);
            txtSname.SendKeys(strSname);
            txtPassword.SendKeys(strPassword);
            txtCpassword.SendKeys(strCpassword);
            txtPnum.SendKeys(strPnum);
            txtAddress.SendKeys(strAddress);
            txtPcode.SendKeys(strPcode);
            txtDescript.SendKeys(strDescript);

            if (btnRegisterBool)
            {
                btnRegister.Click();
            }
        }

        //
        public static void SignUpPage(IWebDriver driver, bool btnRegisterBool, string strFirstName, string strLastName, string strEmail)
        {
            // Get elements for the page
            driver.Url = "http://10.157.123.12/site4/signup.php";

            IWebElement btnRegister = SiteWebElement.btnRegister(driver);
            IWebElement txtFirstName = SiteWebElement.txtFirstName(driver);
            IWebElement txtLastName = SiteWebElement.txtLastName(driver);
            IWebElement txtEmail = SiteWebElement.txtEmail(driver);

            txtFirstName.SendKeys(strFirstName);
            txtLastName.SendKeys(strLastName);
            txtEmail.SendKeys(strEmail);

            if (btnRegisterBool)
            {
                btnRegister.Click();
            }
        }

        public static void Logout(IWebDriver driver, bool lnkLogoutBool)
        {
            // Get elements for the page
            driver.Url = "http://10.157.123.12/site4/index.php";

            IWebElement imgTrumpHead = SiteWebElement.imgTrumpHead(driver);
            IWebElement lnkLogout = SiteWebElement.lnkLogout(driver);

            if (lnkLogoutBool)
            {
                Actions actions = new Actions(driver);
                actions.MoveToElement(imgTrumpHead).Click().Perform();
                Thread.Sleep(100);
                actions.MoveToElement(lnkLogout).Click().Perform();
            }

        }
    }
}
