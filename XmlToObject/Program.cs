using Newtonsoft.Json;
using System;
using System.IO;
using System.Xml;

namespace XmlToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            // string or text from file
            string str = GetTextFromFile("ServiceSalesHistory.txt");

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(str);

            string json = JsonConvert.SerializeXmlNode(xml);
            var model = JsonConvert.DeserializeObject<ServiceSalesHistoryModel>(json);

            foreach (var entry in model.ServiceSalesHistory.sscl)
            {
                Console.WriteLine($"RONumber: {entry.RONumber}; VIN: {entry.VIN}");
            }

            Console.ReadLine();
        }

        private static string GetTextFromFile(string fileName)
        {
            return File.ReadAllTextAsync(fileName).GetAwaiter().GetResult();
        }
    }
}
