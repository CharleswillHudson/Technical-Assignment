using System.Collections;
using System.Text.RegularExpressions;

namespace Technical_Assignment
{
    public class EmailChecker
    {
        ArrayList emails = new ArrayList();
        ArrayList vaildEmails = new ArrayList();
        ArrayList invaildEmails = new ArrayList();
        public EmailChecker(ArrayList emails)
        {
            this.emails = emails;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            foreach (string email in emails)
            {

                Match match = regex.Match(email);
                if (match.Success)
                {
                    vaildEmails.Add(email);
                }
                else
                {
                    invaildEmails.Add(email);
                }
            }
        }

        public ArrayList getVaildEmails() => vaildEmails;
        public ArrayList getInvaildEmails() => invaildEmails;
    }
}