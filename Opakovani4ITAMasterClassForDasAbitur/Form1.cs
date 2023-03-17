namespace Opakovani4ITAMasterClassForDasAbitur
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            var okno = new Mrizka();
            this.Hide();
            okno.ShowDialog();
            this.Show();
        }
    }
}