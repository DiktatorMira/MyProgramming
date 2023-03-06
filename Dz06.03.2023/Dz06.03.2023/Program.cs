using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dz06._03._2023 {
    internal class Program {
        static void Main(string[] args) {
            XmlTextWriter xWrite = new XmlTextWriter("Orders.xml", Encoding.UTF8);
            xWrite.WriteStartDocument();
            xWrite.Formatting = Formatting.Indented;
            xWrite.IndentChar = '\t';
            xWrite.Indentation = 1;
            xWrite.WriteStartElement("orders");
            xWrite.WriteComment("Заказы");
            xWrite.WriteStartElement("firstorder");
            xWrite.WriteComment("Первый заказ");
                xWrite.WriteStartElement("productone");
                xWrite.WriteString("Пылесос");
                xWrite.WriteEndElement();
                xWrite.WriteStartElement("producttwo");
                xWrite.WriteString("Печатная машинка");
                xWrite.WriteEndElement();
                xWrite.WriteStartElement("productthree");
                xWrite.WriteString("Ножницы");
                xWrite.WriteEndElement();
            xWrite.WriteEndElement();
            xWrite.WriteStartElement("secondorder");
            xWrite.WriteComment("Второй заказ");
                xWrite.WriteStartElement("productone");
                xWrite.WriteString("Машина");
                xWrite.WriteEndElement();
                xWrite.WriteStartElement("producttwo");
                xWrite.WriteString("Стамеска");
                xWrite.WriteEndElement();
                xWrite.WriteStartElement("productthree");
                xWrite.WriteString("Шкаф");
                xWrite.WriteEndElement();
            xWrite.WriteEndElement();
            xWrite.WriteStartElement("thirdorder");
            xWrite.WriteComment("Третий заказы");
                xWrite.WriteStartElement("productone");
                xWrite.WriteString("Часы");
                xWrite.WriteEndElement();
                xWrite.WriteStartElement("producttwo");
                xWrite.WriteString("Скамейка");
                xWrite.WriteEndElement();
                xWrite.WriteStartElement("productthree");
                xWrite.WriteString("Шифер");
                xWrite.WriteEndElement();
            xWrite.WriteEndElement();
            Console.WriteLine("Данные сохранены в XML-файл");
            xWrite.Close();
            XmlTextReader xRead = new XmlTextReader("Orders.xml");
            string str = null;
            while (xRead.Read()) {
                if (xRead.NodeType == XmlNodeType.Text) str += xRead.Value + ", ";
                if (xRead.NodeType == XmlNodeType.Element)
                    if(xRead.HasAttributes) while (xRead.MoveToNextAttribute()) str += xRead.Value + ", ";
            }
            Console.WriteLine(str);
            xRead.Close();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Orders.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach(XmlNode xNode in xRoot) {
                foreach(XmlNode xChild in xNode.ChildNodes) {
                    if (xChild.Name == "productone") Console.WriteLine($"Первый продукт: {xChild.InnerText}");
                    else if (xChild.Name == "producttwo") Console.WriteLine($"Второй продукт: {xChild.InnerText}");
                    else if (xChild.Name == "producttрree") Console.WriteLine($"Третий продукт: {xChild.InnerText}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
