using System;
using System.Collections;
using System.IO;


namespace Technical_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //Tests test = new Tests();
            proptUser();




        }

        private static void proptUser()
        {
            string userFile;
            Console.WriteLine("Enter File Name");
            userFile = Console.ReadLine();

            try
            {
                XmlParser xmlParser = new XmlParser(userFile);
                ArrayList emails = xmlParser.getEmail();
                EmailChecker checkedEmails = new EmailChecker(emails);
                Console.WriteLine("valid email list:");
                ArrayList vemails = checkedEmails.getVaildEmails();
                foreach (string vemail in vemails)
                {
                    Console.WriteLine(vemail);
                }
                ArrayList iemails = checkedEmails.getInvaildEmails();
                Console.WriteLine("invaild email list:");
                foreach (string iemail in iemails)
                {
                    Console.WriteLine(iemail);
                }

            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("file not found");
            }
            catch (Exception)
            {
                Console.WriteLine("Error");


            }
        }
    }
}
