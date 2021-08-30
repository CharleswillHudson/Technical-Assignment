using System;
using System.Collections;
using System.IO;


namespace Technical_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //used to run built in test
            //Tests test = new Tests();

            //calls promptUser to prompt the use for file name user
            promptUser();




        }

        private static void promptUser()
        {
            //holders user file name or url
            string userFile;
            Console.WriteLine("Enter File Name");
            userFile = Console.ReadLine();

            try
            {
                //creates new instance of XmlParser with user file
                XmlParser xmlParser = new XmlParser(userFile);
                //returns an ArrayList with emails from the file
                ArrayList emails = xmlParser.getEmail();
                //creates new instance of EmailCheck with files returned from xmlParser
                EmailChecker checkedEmails = new EmailChecker(emails);
                Console.WriteLine("valid email list:");
                //returns list of valid emails and prints to console
                ArrayList vEmails = checkedEmails.getvalidEmails();
                foreach (string vEmail in vEmails)
                {
                    Console.WriteLine(vEmail);
                }
                //returns list of invalid emails and prints to console
                ArrayList iEmails = checkedEmails.getInvalidEmails();
                Console.WriteLine("invalid email list:");
                foreach (string iEmail in iEmails)
                {
                    Console.WriteLine(iEmail);
                }

            }
            //if file is not found
            catch (FileNotFoundException)
            {
                Console.WriteLine("file not found");
            }
            //catch any other errors
            catch (Exception)
            {
                Console.WriteLine("Error");


            }
        }
    }
}
