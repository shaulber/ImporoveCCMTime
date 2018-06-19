using System;
using System.Collections;
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

        private Topology result;
        public AfterForm()
        {
            InitializeComponent();

        }

        private void AfterForm_Load(object sender, EventArgs e)
        {

            var xmlDoc = new XmlDocument();
            string bodyEl = XDocument.Parse(MockData.Response).Descendants("Get_components_response").First().ToString();

            XmlSerializer serializer = new XmlSerializer(typeof(Topology));

            try
            {
                using (TextReader reader = new StringReader(bodyEl))
                {
                    result = (Topology) serializer.Deserialize(reader);
                   
                     treeList1.DataSource = result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        private void treeList1_VirtualTreeGetCellValue(object sender, DevExpress.XtraTreeList.VirtualTreeGetCellValueInfo e)
        {
            e.CellData = ((Component)e.Node).ComponentKey.Type+ ": "+ ((Component)e.Node).ComponentKey.Host;
        }

        private void treeList1_VirtualTreeGetChildNodes(object sender, DevExpress.XtraTreeList.VirtualTreeGetChildNodesInfo e)
        {
            if(e.Node.GetType() == typeof(Topology))
                e.Children = ((Topology)e.Node).Components;
            else if (e.Node.GetType() == typeof(Component))
                e.Children = ((Component)e.Node).Sub_components;
        }

        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var node = treeList1.FocusedNode;
            var data = node.TreeList.DataSource;
        }
    }
}
