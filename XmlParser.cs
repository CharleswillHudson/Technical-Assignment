using System;
using System.Collections;
using System.Xml;

namespace Technical_Assignment
{
    public class XmlParser
    {
        XmlDocument xmlDocument = new XmlDocument();


        public XmlParser(String location)
        {
            xmlDocument.Load(location);



        }
        public ArrayList getEmail()
        {
            XmlNodeList emailList = xmlDocument.GetElementsByTagName("email");
            ArrayList emails = new ArrayList();
            for (int i = 0; i < emailList.Count; i++)
            {
                emails.Add(emailList[i].InnerXml);
            }
            return emails;
        }

    }
}