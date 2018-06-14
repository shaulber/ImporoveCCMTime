using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using DevExpress.Utils.DirectXPaint;

namespace ImproveCCMUploadTime
{
    static class MockData
    {
        private const string PATH = @"c:\response\Response.txt";
        //private const string PATH = @"c:\response\Test.txt";
        private static string _response;
        private static XmlNode _xmlBody;
        private static XmlNodeList nodeList;
        public static string Response { get => _response; set => _response = value; }
        public static XmlNode XmlBody { get => _xmlBody; set => _xmlBody = value; }


        public static void SetData()
        {
            Response = File.ReadAllText(PATH);
        }

        public static void SetXmlBody()
        {
            var newModel = new XmlDocument();
            newModel.LoadXml(Response);

            var root = newModel.DocumentElement;
            
            if (root != null) XmlBody = root.SelectSingleNode("BODY");
            XmlBody = XmlBody?.SelectSingleNode("Get_components_response");
            //  nodeList = XmlBody.SelectNodes("//Component");
            //  getCollection();
        }

     
    }
}
