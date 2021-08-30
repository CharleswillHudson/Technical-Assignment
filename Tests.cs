using System;
using System.Collections;
using System.IO;

namespace Technical_Assignment
{
    //class made to test XmlParser and EmailChecker
    public class Tests
    {
        //ArrayList to test email checker 
        ArrayList validTestList = new ArrayList();
        ArrayList invalidTestList = new ArrayList();
        public Tests()
        {
            //should be returned invalid by the EmailChecker
            invalidTestList.Add("@.com");
            invalidTestList.Add("not valid@gmail.com");
            //should be returned valid by the EmailChecker
            validTestList.Add("valid@gmail.com");
            validTestList.Add("charles@aol.net");

            //creates instance of EmailChecker with known invalid emails
            EmailChecker checkedEmails = new EmailChecker(invalidTestList);
            ArrayList invalidList = checkedEmails.getInvalidEmails();
            //creates instance of EmailChecker with known valid emails
            EmailChecker checkedEmails2 = new EmailChecker(validTestList);
            ArrayList validList = checkedEmails2.getvalidEmails();

            //test to see if invalid emails returned as invalid.
            if (invalidTestList.Count == invalidList.Count)
            {
                for (int i = 0; i < invalidTestList.Count; i++)
                {
                    if (!invalidTestList[i].Equals(invalidList[i]))
                    {
                        Console.WriteLine("Invalid Email Fail");
                        break;
                    }
                    if (i == invalidTestList.Count - 1)
                    {
                        Console.WriteLine("Invalid Email pass");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid Email Fail");
            }
             //test to see if valid emails returned as valid.
            if (validTestList.Count == validList.Count)
            {
                for (int i = 0; i < validTestList.Count; i++)
                {
                    if (!validTestList[i].Equals(validList[i]))
                    {
                        Console.WriteLine("valid Email Fail");
                        break;
                    }
                    if (i == validTestList.Count - 1)
                    {
                        Console.WriteLine("valid Email pass");
                    }
                }

            }
            else
            {
                Console.WriteLine("valid Email Fail");
            }

            //creates new instance of XmlParser used for test
            try
            {
                XmlParser xmlParser = new XmlParser("test.xml");
                //creates an array of emails in test.xml to compare to the list XmlParser finds in the file
                ArrayList emails = new ArrayList(){
                "testPerson1@gmail.com","testPerson2@gmail.com","testPerson3gmail.com","testPerson4@gmailcom","test Person5@gmail.com","testPerson6@.com"
            };

                ArrayList foundEmails = xmlParser.getEmail();

                //confirms if known email list matches the emails returned by XmlParser
                if (emails.Count == foundEmails.Count)
                {
                    for (int i = 0; i < emails.Count; i++)
                    {

                        if (!emails[i].Equals(foundEmails[i]))
                        {
                            Console.WriteLine("XmlParser Fail");
                            break;
                        }
                        if (i == emails.Count - 1)
                        {
                            Console.WriteLine("XmlParser pass");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("XmlParser failed");

                }
            }
            catch
            {
                Console.WriteLine("XmlParser failed");
            }


        }



    }




}