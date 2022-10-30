namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }

        private void BackBlue_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Blue;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            smallsize.Font = new Font("Arial", 7, FontStyle.Bold);
           
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem.Font = new Font("Arial", 14, FontStyle.Bold);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            largeToolStripMenuItem.Font = new Font("Arial", 24, FontStyle.Bold);
        }
    }
}