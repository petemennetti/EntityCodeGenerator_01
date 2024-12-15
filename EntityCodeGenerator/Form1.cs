namespace EntityCodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {

            EntityFileGenerator.CreateEntityFile(
                txtNameSpace.Text,
                txtServer.Text,
                txtDatabase.Text,
                txtTableOrView.Text,
                txtOutputPath.Text

                ); // Call the static method
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtServer.Text = ".";
            txtDatabase.Text = "BookStoreDb";
            txtTableOrView.Text = "Authors";
             txtOutputPath.Text = @"c:\dev\" + $"{txtTableOrView.Text}.cs";
        }
    }
}
