namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Form2 reservar = new Form2();
            reservar.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la aplicación?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnOpciones_Click(object sender, EventArgs e)
        {
            Form3 administrar = new Form3();
            administrar.ShowDialog();
        }
    }
}