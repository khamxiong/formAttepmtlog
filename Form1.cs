namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int attempt = 1;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textName.Text =="kham"&& textPassword.Text == "1234")
            {
                MessageBox.Show("You have loged in");
                
            }
            else
            {
                MessageBox.Show("incorrect password or userName please try agian\n Attempts done" +" " +attempt+" "+ "out of 3");
                attempt++;
               
            }
            if(attempt == 4)
            {
                MessageBox.Show("you have reached the maximum number of attempts");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textPassword.Clear();
            textName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}