using System;
using System.Collections;
using System.IO;

namespace Technical_Assignment
{
    public class Tests
    {
        ArrayList vaildTestList = new ArrayList();
        ArrayList invaildTestList = new ArrayList();
        public Tests()
        {
            invaildTestList.Add("@.com");
            invaildTestList.Add("not vaild@gmail.com");

            vaildTestList.Add("vaild@gmail.com");
            vaildTestList.Add("charles@aol.net");
            EmailChecker checkedEmails = new EmailChecker(invaildTestList);
            ArrayList invaildList = checkedEmails.getInvaildEmails();
            EmailChecker checkedEmails2 = new EmailChecker(vaildTestList);
            ArrayList vaildList = checkedEmails2.getVaildEmails();


            if (invaildTestList.Count == invaildList.Count)
            {
                for (int i = 0; i < invaildTestList.Count; i++)
                {
                    if (!invaildTestList[i].Equals(invaildList[i]))
                    {
                        Console.WriteLine("Invaild Email Fail");
                        break;
                    }
                    if (i == invaildTestList.Count - 1)
                    {
                        Console.WriteLine("Invaild Email pass");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invaild Email Fail");
            }
            if (vaildTestList.Count == vaildList.Count)
            {
                for (int i = 0; i < vaildTestList.Count; i++)
                {
                    if (!vaildTestList[i].Equals(vaildList[i]))
                    {
                        Console.WriteLine("Vaild Email Fail");
                        break;
                    }
                    if (i == vaildTestList.Count - 1)
                    {
                        Console.WriteLine("Vaild Email pass");
                    }
                }

            }
            else
            {
                Console.WriteLine("Vaild Email Fail");
            }
            try
            {
                XmlParser xmlParser = new XmlParser("test.xml");
                ArrayList emails = new ArrayList(){
                "testPerson1@gmail.com","testPerson2@gmail.com","testPerson3gmail.com","testPerson4@gmailcom","test Person5@gmail.com","testPerson6@.com"
            };

                ArrayList foundEmails = xmlParser.getEmail();
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