using System;
using System.Collections;
using System.Xml;

namespace Technical_Assignment
{
    public class XmlParser
    {
        XmlDocument xmlDocument = new XmlDocument();

        //constructor takes a file name/URL
        public XmlParser(String location)
        {
            xmlDocument.Load(location);



        }

        //getter for emails in XML File
        public ArrayList getEmail()
        {
            //I made the assumption that the tagname would be email in the file
            XmlNodeList emailList = xmlDocument.GetElementsByTagName("email");
            ArrayList emails = new ArrayList();

            //takes the node list and adds it to an ArrayList for simplicity 
            for (int i = 0; i < emailList.Count; i++)
            {
                emails.Add(emailList[i].InnerXml);
            }
            return emails;
        }

    }
}