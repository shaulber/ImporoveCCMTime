using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace ImproveCCMUploadTime
{
    public partial class BeforeForm : Form
    {
        public BeforeForm()
        {

            InitializeComponent();
            
          //  treeList1.DataSource = dsModel.Dt;
         //   treeList1.DataSource = l;
            //treeList1.DataMember = dsModel.DSModel.ToString();
            //DataSet ds = new DataSet();
            //var xmlDoc = new System.Xml.XmlDocument();
            //xmlDoc.LoadXml(MockData.XmlBody.OuterXml);

            //XmlNodeReader xmlReader = new XmlNodeReader(xmlDoc);

            //ds.ReadXml(xmlReader);

        }

        private void BeforeForm_Load(object sender, EventArgs e)
        {
            Model1 dsModel = new Model1();

            //for(int i=0; i< )

            MessageBox.Show("Rows = " + dsModel.DSModel.Tables[0].Rows.Count.ToString());
        }
    }
}
