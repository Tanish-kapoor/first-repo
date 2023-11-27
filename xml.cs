susing System;
using System.Xml;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string tempXml = @"
            <root>
                <Students><Student ID='1' Name='XYZ' /></Students>
                <courses>
                    <C name='c#' code='csu000' />
                    <C name='java' code='csu001' />
                    <C name='eng' code='csu002' />
                    <C name='maths' code='csu003' />
                    <C name='algo' code='csu004' />
                </courses>
            </root>";

        XmlDocument doc4 = new XmlDocument();
        doc4.LoadXml(tempXml);
        XmlNode studentNode = doc4.SelectSingleNode("/root/Students/Student");
        string studentId = studentNode.Attributes["ID"].Value;
        string studentName = studentNode.Attributes["Name"].Value;

        XmlNodeList courseNodes = doc4.SelectNodes("/root/courses/C");

        Console.WriteLine($"Student ID: {studentId}, Name: {studentName}");

        foreach (XmlNode courseNode in courseNodes)
        {
            string courseName = courseNode.Attributes["name"].Value;
            string courseCode = courseNode.Attributes["code"].Value;

            Console.WriteLine($"Course Name: {courseName}, Code: {courseCode}");
        }
    }
}
