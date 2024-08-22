namespace minigame_play
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmcpt frmcpt = new frmcpt();
            frmcpt.Show();
            this.Hide();
        }
    }
}
