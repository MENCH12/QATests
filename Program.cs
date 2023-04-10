using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// Using the mySQL namespace
using MySql.Data.MySqlClient;

namespace SeleniumGit2023
{
    internal class Program
    {
        private static MySqlConnection connection;

        static void Main(string[] args)
        {
            // ********************************************************************************** 
            // ********************************** INITIALIZE ************************************ 
            // **********************************************************************************

            //SiteReset();

            string contactButtonTestResult = "";
            string batmanLoginNavTestResult = "";
            string signUpLinkTestResult = "";
            string validSignInTestResult = "";
            string invalidSignInTestResult = "";
            string blankFirstNameTestResult = "";
            string firstNameOver50CharsTestResult = "";
            string firstNameAcceptableTestResult = "";
            string blankLastNameTestResult = "";
            string lastNameOver50CharsTestResult = "";
            string lastNameAcceptableTestResult = "";
            string blankEmailTestResult = "";
            string badEmailAddressTestResult = "";
            string emailOver100CharsTestResult = "";
            string emailAcceptableTestResult = "";
            string formSubmitTestResult = "";
            string cpasswordTestResult = "";
            string blankPasswordTestResult = "";
            string blankPasswordConfirmTestResult = "";
            string blankScreenNameTestResult = "";
            string PostalCodeTestResult = "";
            string blankPostalCodeTestResult = "";
            string PhoneNumberTestResult = "";
            string blankPhoneNumberTestResult = "";
            string AddressTestResult = "";
            string blankAddressTestResult = "";
            string sNameSCTestResult = "";
            string tweetTestResult = "";

            // Create the Web Driver
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            // Make sure test window is full screen, some areas are responsive
            driver.Manage().Window.Maximize();

            // ********************************************************************************** 
            // ************************************* TESTS ************************************** 
            // ********************************************************************************** 

            // *****************************************************************************************************
            // ********************************************************************************** Run the 1st test *
            // *****************************************************************************************************

            bool ContactButtonTest = SiteTest.ContactButtonTest(driver);

            // Display the results of the test
            if (ContactButtonTest)
            {
                Console.WriteLine("ContactButtonTest - Contact Us Page Success: Passed!");
                contactButtonTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("ContactButtonTest - Contact Us Page Success: Failed...");
                contactButtonTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 2nd test *
            // *****************************************************************************************************

            bool BatmanLoginNavTest = SiteTest.BatmanLoginNavTest(driver);

            // Display the results of the test
            if (BatmanLoginNavTest)
            {
                Console.WriteLine("BatmanLoginNavTest - Login Page Success: Passed!");
                batmanLoginNavTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("BatmanLoginNavTest - Login Page Success: Failed...");
                batmanLoginNavTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 3rd test *
            // *****************************************************************************************************

            bool SignUpLinkTest = SiteTest.SignUpLinkTest(driver);

            // Display the results of the test
            if (SignUpLinkTest)
            {
                Console.WriteLine("SignUpLinkTest - Sign Up Page Success: Passed!");
                signUpLinkTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("SignUpLinkTest - Sign Up Page Success: Failed...");
                signUpLinkTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 4th test *
            // *****************************************************************************************************

            bool InvalidSignInTest = SiteTest.InvalidSignInTest(driver);

            // Display the results of the test
            if (InvalidSignInTest)
            {
                Console.WriteLine("InvalidSignInTest - Sign In Success: Passed!");
                invalidSignInTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("InvalidSignInTest - Sign In Success: Failed...");
                invalidSignInTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 5th test *
            // *****************************************************************************************************

            bool ValidSignInTest = SiteTest.ValidSignInTest(driver);

            // Display the results of the test
            if (ValidSignInTest)
            {
                Console.WriteLine("ValidSignInTest - Sign In Success: Passed!");
                validSignInTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("ValidSignInTest - Sign In Success: Failed...");
                validSignInTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 6th test *
            // *****************************************************************************************************

            bool BlankFirstNameTest = SiteTest.BlankFirstNameTest(driver);

            // Display the results of the test
            if (BlankFirstNameTest)
            {
                Console.WriteLine("BlankFirstNameTest - Sign In Success: Passed!");
                blankFirstNameTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("BlankFirstNameTest - Sign In Success: Failed...");
                blankFirstNameTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 7th test *
            // *****************************************************************************************************

            bool FirstNameOver50CharsTest = SiteTest.FirstNameOver50CharsTest(driver);

            // Display the results of the test
            if (FirstNameOver50CharsTest)
            {
                Console.WriteLine("FirstNameOver50CharsTest - Sign In Success: Passed!");
                firstNameOver50CharsTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("FirstNameOver50CharsTest - Sign In Success: Failed...");
                firstNameOver50CharsTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 8th test *
            // *****************************************************************************************************

            bool FirstNameAcceptableTest = SiteTest.FirstNameAcceptableTest(driver);

            // Display the results of the test
            if (FirstNameAcceptableTest)
            {
                Console.WriteLine("FirstNameAcceptableTest - Sign In Success: Passed!");
                firstNameAcceptableTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("FirstNameAcceptableTest - Sign In Success: Failed...");
                firstNameAcceptableTestResult = "FAIL";
            }

            // *****************************************************************************************************
            // ********************************************************************************** Run the 9th test *
            // *****************************************************************************************************

            bool BlankLastNameTest = SiteTest.BlankLastNameTest(driver);

            // Display the results of the test
            if (BlankLastNameTest)
            {
                Console.WriteLine("BlankLastNameTest - Sign In Success: Passed!");
                blankLastNameTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("BlankLastNameTest - Sign In Success: Failed...");
                blankLastNameTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 10th test *
            // ******************************************************************************************************

            bool LastNameOver50CharsTest = SiteTest.LastNameOver50CharsTest(driver);

            // Display the results of the test
            if (LastNameOver50CharsTest)
            {
                Console.WriteLine("LastNameOver50CharsTest - Sign In Success: Passed!");
                lastNameOver50CharsTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("LastNameOver50CharsTest - Sign In Success: Failed...");
                lastNameOver50CharsTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 11th test *
            // ******************************************************************************************************

            bool LastNameAcceptableTest = SiteTest.LastNameAcceptableTest(driver);

            // Display the results of the test
            if (LastNameAcceptableTest)
            {
                Console.WriteLine("LastNameAcceptableTest - Sign In Success: Passed!");
                lastNameAcceptableTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("LastNameAcceptableTest - Sign In Success: Failed...");
                lastNameAcceptableTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 12th test *
            // ******************************************************************************************************

            bool BlankEmailTest = SiteTest.BlankEmailTest(driver);

            // Display the results of the test
            if (BlankEmailTest)
            {
                Console.WriteLine("BlankEmailTest - Sign In Success: Passed!");
                blankEmailTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("BlankEmailTest - Sign In Success: Failed...");
                blankEmailTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 13th test *
            // ******************************************************************************************************

            bool BadEmailAddressTest = SiteTest.BadEmailAddressTest(driver);

            // Display the results of the test
            if (BadEmailAddressTest)
            {
                Console.WriteLine("BadEmailAddressTest - Sign In Success: Passed!");
                badEmailAddressTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("BadEmailAddressTest - Sign In Success: Failed...");
                badEmailAddressTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 14th test *
            // ******************************************************************************************************

            bool EmailOver100CharsTest = SiteTest.EmailOver100CharsTest(driver);

            // Display the results of the test
            if (EmailOver100CharsTest)
            {
                Console.WriteLine("EmailOver100CharsTest - Sign In Success: Passed!");
                emailOver100CharsTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("EmailOver100CharsTest - Sign In Success: Failed...");
                emailOver100CharsTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 15th test *
            // ******************************************************************************************************

            bool EmailAcceptableTest = SiteTest.EmailAcceptableTest(driver);

            // Display the results of the test
            if (EmailAcceptableTest)
            {
                Console.WriteLine("EmailAcceptableTest - Sign In Success: Passed!");
                emailAcceptableTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("EmailAcceptableTest - Sign In Success: Failed...");
                emailAcceptableTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 16th test *
            // ******************************************************************************************************

            bool FormSubmitTest = SiteTest.FormSubmitTest(driver);

            // Display the results of the test
            if (FormSubmitTest)
            {
                Console.WriteLine("FormSubmitTest - Sign In Success: Passed!");
                formSubmitTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("FormSubmitTest - Sign In Success: Failed...");
                formSubmitTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 17th test *
            // ******************************************************************************************************

            bool CpasswordTest = SiteTest.CpasswordTest(driver);

            // Display the results of the test
            if (CpasswordTest)
            {
                Console.WriteLine("CpasswordTest - Sign In Success: Passed!");
                cpasswordTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("CpasswordTest - Sign In Success: Failed...");
                cpasswordTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 18th test *
            // ******************************************************************************************************

            bool BlankPasswordTest = SiteTest.BlankPwordTest(driver);

            // Display the results of the test
            if (BlankPasswordTest)
            {
                Console.WriteLine("BlankPasswordTest - Sign In Success: Passed!");
                blankPasswordTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("BlankPasswordTest - Sign In Success: Failed...");
                blankPasswordTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 19th test *
            // ******************************************************************************************************

            bool BlankPasswordConfirmTest = SiteTest.noPasswordTest(driver);

            // Display the results of the test
            if (BlankPasswordConfirmTest)
            {
                Console.WriteLine("BlankPasswordConfirmTest - Sign In Success: Passed!");
                blankPasswordConfirmTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("BlankPasswordConfirmTest - Sign In Success: Failed...");
                blankPasswordConfirmTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 20th test *
            // ******************************************************************************************************

            bool BlankScreenNameTest = SiteTest.noScreenNameTest(driver);

            // Display the results of the test
            if (BlankScreenNameTest)
            {
                Console.WriteLine("noScreenNameTest - Sign In Success: Passed!");
                blankScreenNameTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("noScreenNameTest - Sign In Success: Failed...");
                blankScreenNameTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 21st test *
            // ******************************************************************************************************

            bool PostalCodeTest = SiteTest.PostalCodeAreaTest(driver);

            // Display the results of the test
            if (PostalCodeTest)
            {
                Console.WriteLine("PostalCodeTest - Sign In Success: Passed!");
                PostalCodeTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("PostalCodeTest - Sign In Success: Failed...");
                PostalCodeTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 22nd test *
            // ******************************************************************************************************

            bool BlankPostalCodeTest = SiteTest.NoPostalCodeTest(driver);

            // Display the results of the test
            if (BlankPostalCodeTest)
            {
                Console.WriteLine("blankPostalCodeTest - Sign In Success: Passed!");
                blankPostalCodeTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("blankPostalCodeTest - Sign In Success: Failed...");
                blankPostalCodeTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 23rd test *
            // ******************************************************************************************************

            bool PhoneNumberTest = SiteTest.PhoneNumberTest(driver);

            // Display the results of the test
            if (PhoneNumberTest)
            {
                Console.WriteLine("PhoneNumberTest - Sign In Success: Passed!");
                PhoneNumberTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("PhoneNumberTest - Sign In Success: Failed...");
                PhoneNumberTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 24th test *
            // ******************************************************************************************************

            bool BlankPhoneNumberTest = SiteTest.noPhoneNumberTest(driver);

            // Display the results of the test
            if (BlankPhoneNumberTest)
            {
                Console.WriteLine("blankPhoneNumberTest - Sign In Success: Passed!");
                blankPhoneNumberTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("blankPhoneNumberTest - Sign In Success: Failed...");
                blankPhoneNumberTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 25th test *
            // ******************************************************************************************************

            bool AddressTest = SiteTest.AddressTest(driver);

            // Display the results of the test
            if (AddressTest)
            {
                Console.WriteLine("AddressTest - Sign In Success: Passed!");
                AddressTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("AddressTest - Sign In Success: Failed...");
                AddressTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 26th test *
            // ******************************************************************************************************

            bool blankAddressTest = SiteTest.noAddressTest(driver);

            // Display the results of the test
            if (blankAddressTest)
            {
                Console.WriteLine("blankAddressTest - Sign In Success: Passed!");
                blankAddressTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("blankAddressTest - Sign In Success: Failed...");
                blankAddressTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 27th test *
            // ******************************************************************************************************

            bool sNameSCTest = SiteTest.sNameSCTest(driver);

            // Display the results of the test
            if (sNameSCTest)
            {
                Console.WriteLine("sNameSCTest - Sign In Success: Passed!");
                sNameSCTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("sNameSCTest - Sign In Success: Failed...");
                sNameSCTestResult = "FAIL";
            }

            // ******************************************************************************************************
            // ********************************************************************************** Run the 28th test *
            // ******************************************************************************************************

            bool tweetTest = SiteTest.tweetTest(driver);

            // Display the results of the test
            if (tweetTest)
            {
                Console.WriteLine("tweetTest - Sign In Success: Passed!");
                tweetTestResult = "PASS";
            }
            else
            {
                Console.WriteLine("tweetTest - Sign In Success: Failed...");
                tweetTestResult = "FAIL";
            }



            // ********************************************************************************** 
            // ************************************* OUTPUT ************************************* 
            // ********************************************************************************** 

            // Close the Web Driver when finished
            driver.Quit();

            // Prompt the next test (Because I want to watch them run individually :) )
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t*****************");
            Console.WriteLine("\t* FINAL RESULTS *");
            Console.WriteLine("\t*****************");
            Console.WriteLine();
            Console.WriteLine("\t01.\tContact Button Test \t\t\t= " + contactButtonTestResult);
            Console.WriteLine("\t02.\tBatman Login Nav Test \t\t\t= " + batmanLoginNavTestResult);
            Console.WriteLine("\t03.\tSign Up Link Test \t\t\t= " + signUpLinkTestResult);
            Console.WriteLine("\t04.\tInvalid Sign In Test \t\t\t= " + invalidSignInTestResult);
            Console.WriteLine("\t05.\tValid Sign In Test \t\t\t= " + validSignInTestResult);
            Console.WriteLine("\t06.\tBlank First Name Test \t\t\t= " + blankFirstNameTestResult);
            Console.WriteLine("\t07.\tFirst Name Over 50 Chars Test \t\t= " + firstNameOver50CharsTestResult);
            Console.WriteLine("\t08.\tFirst Name Acceptable Test \t\t= " + firstNameAcceptableTestResult);
            Console.WriteLine("\t09.\tBlank Last Name Test \t\t\t= " + blankLastNameTestResult);
            Console.WriteLine("\t10.\tLast Name Over 50 Chars Test \t\t= " + lastNameOver50CharsTestResult);
            Console.WriteLine("\t11.\tLast Name Acceptable Test \t\t= " + lastNameAcceptableTestResult);
            Console.WriteLine("\t12.\tBlank Email Test \t\t\t= " + blankEmailTestResult);
            Console.WriteLine("\t13.\tBad Email Address Test \t\t\t= " + badEmailAddressTestResult);
            Console.WriteLine("\t14.\tEmail Over 100 Chars Test \t\t= " + emailOver100CharsTestResult);
            Console.WriteLine("\t15.\tEmail Acceptable Test \t\t\t= " + emailAcceptableTestResult);
            Console.WriteLine("\t16.\tForm Submit Test \t\t\t= " + formSubmitTestResult);
            Console.WriteLine("\t17.\tDifferent Password Test \t\t= " + cpasswordTestResult);
            Console.WriteLine("\t18.\tBlank Password Test \t\t\t= " + blankPasswordTestResult);
            Console.WriteLine("\t19.\tBlank Password Confirm Test \t\t= " + blankPasswordConfirmTestResult);
            Console.WriteLine("\t20.\tBlank ScreenName Test \t\t\t= " + blankScreenNameTestResult);
            Console.WriteLine("\t21.\tPostal Code Test \t\t\t= " + PostalCodeTestResult);
            Console.WriteLine("\t22.\tBlank Postal Code Test \t\t\t= " + blankPostalCodeTestResult);
            Console.WriteLine("\t23.\tPhone Number Test \t\t\t= " + PhoneNumberTestResult);
            Console.WriteLine("\t24.\tBlank Phone Number Test \t\t= " + blankPhoneNumberTestResult);
            Console.WriteLine("\t25.\tAddress Test \t\t\t= " + AddressTestResult);
            Console.WriteLine("\t26.\tBlank Address Test \t\t\t\t= " + blankAddressTestResult);
            Console.WriteLine("\t27.\tScreenName Special Characters Test \t= " + sNameSCTestResult);
            Console.WriteLine("\t28.\tSend Tweet Test \t= " + tweetTestResult);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tPress ENTER to quit...");
            Console.ReadLine();
        }

        public static void SiteReset()
        {
            string myConnectionString = "server=10.157.123.12;database=bitter-site4;uid=site4;pwd=KgpRPAIfliuGXxM8;";
            connection = new MySqlConnection(myConnectionString);
            MySqlCommand command = new MySqlCommand();

            command.Connection = connection;
            command.CommandText = "reset";
            command.CommandType = System.Data.CommandType.StoredProcedure;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
