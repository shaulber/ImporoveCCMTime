using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImproveCCMUploadTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void beforeBtn_Click(object sender, EventArgs e)
        {
            var beforeForm = new BeforeForm();
            beforeForm.Show();
        }

        private void afterBtn_Click(object sender, EventArgs e)
        {
            var afterForm = new AfterForm();
            afterForm.Show();
        }
    }
}
