namespace Obfuscar_CS_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String StrText = "��r���e";
            String StrCaption = "���D";
            DialogResult myResult = MessageBox.Show(StrText, StrCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                this.Text = StrText;//���F�O
            }
            else if (myResult == DialogResult.No)
            {
                this.Text = StrCaption;//���F�_
            }
        }
    }
}