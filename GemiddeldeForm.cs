using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oef2
{
    public partial class GemiddeldeForm : Form
    {
        public GemiddeldeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dialoogNieuwGetal dialoogbox = new dialoogNieuwGetal();
            dialoogbox.ShowDialog();

            listBox1.Items.Add(double.Parse(dialoogbox.getal));

            double gemiddelde = 0;

            foreach (double getal in listBox1.Items)
            {
                gemiddelde = gemiddelde + getal;
            }

            textBox1.Text = (gemiddelde / listBox1.Items.Count).ToString();
        }
    }
}
