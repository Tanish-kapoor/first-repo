using System;
using System.Xml;
public class HelloWorld{    
	public static void Main(string[] args)    {            
		string tempXml = @"<Students><Student ID='1' Name='ABC' /><Student ID='2' Name='CDE' /></Students>";
		XmlDocument doc4 = new XmlDocument();
		doc4.LoadXml(tempXml);
		XmlElement XEle = doc4.CreateElement("Student");
		XEle.SetAttribute("ID", "3");
		XEle.SetAttribute("Name", "XYZ");
		int nodeld=1;                                                              //For Editing
	    XmlNode node=doc4.SelectSingleNode("/Students/Student[@ID="+nodeld+"]");
	    node.Attributes["Name"].Value="Tanish Kapoor";
	    node.Attributes["ID"].Value="111";
        int nodeld2=2;                                                             //For Deleting
	    XmlNode nodeToDelete=doc4.SelectSingleNode("/Students/Student[@ID="+nodeld2+"]");
	    if(nodeToDelete!=null){
	        nodeToDelete.ParentNode.RemoveChild(nodeToDelete);
	    }
		doc4.DocumentElement.AppendChild(XEle.Clone());
		doc4.Save(Console.Out);
		Console.WriteLine();    
	}
}