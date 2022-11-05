namespace oef2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openGemiddeldeFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GemiddeldeForm gemiddeldeForm = new GemiddeldeForm();
            gemiddeldeForm.MdiParent = this;
            gemiddeldeForm.Show();
            gemiddeldeForm.Location = new Point();
        }
    }
}