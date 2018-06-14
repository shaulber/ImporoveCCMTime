using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using DevExpress.XtraTreeList.Nodes;

namespace ImproveCCMUploadTime
{
    public partial class AfterForm : Form

    {
        public AfterForm()
        {
            InitializeComponent();

            Dictionary<string, string> topology = new Dictionary<string, string>();

            // var t =MockData.XmlBody;
            try
            {
                XElement xmlTree = XElement.Parse(MockData.Response);
                foreach (XElement element in xmlTree.Descendants())
                {
                    int i = 1;
                   
                }
            }
            catch (Exception ex)
            {
                
            }
            


        }

        private void AfterForm_Load(object sender, EventArgs e)
        {

            var xmlDoc = new XmlDocument();
            string bodyEl = XDocument.Parse(MockData.Response).Descendants("Get_components_response").First().ToString();
            //string bodyEl = MockData.XmlBody.InnerXml;

            //var comp = new XmlDocument();
            //comp.LoadXml(bodyXMl);

            //var root = comp.DocumentElement;

            //var components =root.InnerXml;

            XmlSerializer serializer = new XmlSerializer(typeof(Topology));

            try
            {
                using (TextReader reader = new StringReader(bodyEl))
                {
                    Topology result = (Topology) serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           


            TreeListNode codeNode = treeList1.AppendNode(null, null);
            codeNode.SetValue("name", "Orion");

            TreeListNode docNode = treeList1.AppendNode(null, null);
            docNode.SetValue("name", "Venus");

            TreeListNode videoNode = treeList1.AppendNode(null, null);
            videoNode.SetValue("name", "Pluto");

            TreeListNode childNode = null;
            childNode = treeList1.AppendNode(null, codeNode);
            childNode.SetValue("name", "Wesal");

            TreeListNode omerdNode = null;
            omerdNode = treeList1.AppendNode(null, codeNode);
            omerdNode.SetValue("name", "Omer");

            TreeListNode shaulNode = null;
            shaulNode = treeList1.AppendNode(null, codeNode);
            shaulNode.SetValue("name", "Shaul");

            TreeListNode nisreenNode = null;
            nisreenNode = treeList1.AppendNode(null, docNode);
            nisreenNode.SetValue("name", "Nisreen");

            TreeListNode haneenNode = null;
            haneenNode = treeList1.AppendNode(null, docNode);
            haneenNode.SetValue("name", "Haneen");

            TreeListNode saiefNode = null;
            saiefNode = treeList1.AppendNode(null, docNode);
            saiefNode.SetValue("name", "Saif");

            TreeListNode shacharNode = null;
            shacharNode = treeList1.AppendNode(null, docNode);
            shacharNode.SetValue("name", "Shachar");

            TreeListNode ramiNode = null;
            ramiNode = treeList1.AppendNode(null, videoNode);
            ramiNode.SetValue("name", "Rami");

            TreeListNode aviadNode = null;
            aviadNode = treeList1.AppendNode(null, videoNode);
            aviadNode.SetValue("name", "Aviad");

            TreeListNode mosheNode = null;
            mosheNode = treeList1.AppendNode(null, videoNode);
            mosheNode.SetValue("name", "Moshe");


        }
    }
}
