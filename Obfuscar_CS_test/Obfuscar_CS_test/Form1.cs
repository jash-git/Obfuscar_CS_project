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
            String StrText = "文字內容";
            String StrCaption = "標題";
            DialogResult myResult = MessageBox.Show(StrText, StrCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (myResult == DialogResult.Yes)
            {
                this.Text = StrText;//按了是
            }
            else if (myResult == DialogResult.No)
            {
                this.Text = StrCaption;//按了否
            }
        }
    }
}