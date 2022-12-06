namespace PE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Оценка физического развития и функционального состояния организма человека";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
            main.Location = this.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}