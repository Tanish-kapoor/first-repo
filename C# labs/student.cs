using System;
using System.Xml;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tempXml = @"<Students><Student StudID='1' Name='Name 1' /><Student StudID='2' Name='Name 2' /></Students>";
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(tempXml);

        XmlElement studentElement = doc.CreateElement("Student");
        studentElement.SetAttribute("StudID", "3");
        studentElement.SetAttribute("Name", "Name 3");

        doc.DocumentElement.AppendChild(studentElement);

        doc.Save(Console.Out);
        Console.WriteLine();
    }
}
