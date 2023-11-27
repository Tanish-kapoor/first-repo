using System;
using System.Xml;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tempXml = @"<Students><Student StudID='1' Name='Name 1' /><Student StudID='2' Name='Name 2' /></Students>";
        int nodeId = 2;
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(tempXml);

        XmlNode node = doc.SelectSingleNode("/Students/Student[@StudID=" + nodeId + "]");
        XmlNodeList students = doc.SelectNodes("/Students/Student");
        node.Attributes["Name"].Value = "Tanish kapoor";

        doc.Save(Console.Out);
        Console.WriteLine();
    }
}
