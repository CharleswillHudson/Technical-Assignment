using System.Collections;
using System.Text.RegularExpressions;

namespace Technical_Assignment
{
    public class EmailChecker
    {
        //holds unchecked emails
        ArrayList emails = new ArrayList();
        //holds valid and invalid emails respectively 
        ArrayList validEmails = new ArrayList();
        ArrayList invalidEmails = new ArrayList();

        //class constructor takes an ArrayList of emails
        public EmailChecker(ArrayList emails)
        {
            this.emails = emails;
            //Regex expression to test emails
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            foreach (string email in emails)
            {

                Match match = regex.Match(email);
                if (match.Success)
                {
                    validEmails.Add(email);
                }
                else
                {
                    invalidEmails.Add(email);
                }
            }
        }
        //getters
        public ArrayList getvalidEmails() => validEmails;
        public ArrayList getInvalidEmails() => invalidEmails;
    }
}