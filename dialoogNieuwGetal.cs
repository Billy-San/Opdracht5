using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace oef2
{
    public partial class dialoogNieuwGetal : Form
    {
        public dialoogNieuwGetal()
        {
            InitializeComponent();
        }
        public string getal { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            getal = textBox1.Text;
            DialogResult dialogResult = DialogResult.OK;
        }
    }
}
