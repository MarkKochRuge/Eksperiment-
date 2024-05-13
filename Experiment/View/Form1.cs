using Experiment.View;

namespace Experiment
{
    public partial class Form1 : Form
    {
        Bolig formb;
        
        public Form1()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            formb = new Bolig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(121, 81, 168);
            button2.BackColor = Color.FromArgb(105, 54, 158);
            button3.BackColor = Color.FromArgb(105, 54, 158);
            button4.BackColor = Color.FromArgb(105, 54, 158);
            labelonp.Text = "BOLIG";
            formb.TopLevel = false;
            Screenpanel.Controls.Add(formb);
            formb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(105, 54, 158);
            button2.BackColor = Color.FromArgb(121, 81, 168);
            button3.BackColor = Color.FromArgb(105, 54, 158);
            button4.BackColor = Color.FromArgb(105, 54, 158);
            labelonp.Text = "SÆLGER";
            formb.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(105, 54, 158);
            button2.BackColor = Color.FromArgb(105, 54, 158);
            button3.BackColor = Color.FromArgb(121, 81, 168);
            button4.BackColor = Color.FromArgb(105, 54, 158);
            labelonp.Text = "KØBER";
            formb.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(105, 54, 158);
            button2.BackColor = Color.FromArgb(105, 54, 158);
            button3.BackColor = Color.FromArgb(105, 54, 158);
            button4.BackColor = Color.FromArgb(121, 81, 168);
            labelonp.Text = "MÆGLER";
            formb.Hide();
        }

        private void logoPnl_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(105, 54, 158);
            button2.BackColor = Color.FromArgb(105, 54, 158);
            button3.BackColor = Color.FromArgb(105, 54, 158);
            button4.BackColor = Color.FromArgb(105, 54, 158);
            labelonp.Text = "HJEM";
            formb.Hide();
        }
    }
}
