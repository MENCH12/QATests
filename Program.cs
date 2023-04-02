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
            Console.WriteLine("\t01.\tContact Button Test \t\t= " + contactButtonTestResult);
            Console.WriteLine("\t02.\tBatman Login Nav Test \t\t= " + batmanLoginNavTestResult);
            Console.WriteLine("\t03.\tSign Up Link Test \t\t= " + signUpLinkTestResult);
            Console.WriteLine("\t04.\tInvalid Sign In Test \t\t= " + invalidSignInTestResult);
            Console.WriteLine("\t05.\tValid Sign In Test \t\t= " + validSignInTestResult);
            Console.WriteLine("\t06.\tBlank First Name Test \t\t= " + blankFirstNameTestResult);
            Console.WriteLine("\t07.\tFirst Name Over 50 Chars Test \t= " + firstNameOver50CharsTestResult);
            Console.WriteLine("\t08.\tFirst Name Acceptable Test \t= " + firstNameAcceptableTestResult);
            Console.WriteLine("\t09.\tBlank Last Name Test \t\t= " + blankLastNameTestResult);
            Console.WriteLine("\t10.\tLast Name Over 50 Chars Test \t= " + lastNameOver50CharsTestResult);
            Console.WriteLine("\t11.\tLast Name Acceptable Test \t= " + lastNameAcceptableTestResult);
            Console.WriteLine("\t12.\tBlank Email Test \t\t= " + blankEmailTestResult);
            Console.WriteLine("\t13.\tBad Email Address Test \t\t= " + badEmailAddressTestResult);
            Console.WriteLine("\t14.\tEmail Over 100 Chars Test \t= " + emailOver100CharsTestResult);
            Console.WriteLine("\t15.\tEmail Acceptable Test \t\t= " + emailAcceptableTestResult);
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
