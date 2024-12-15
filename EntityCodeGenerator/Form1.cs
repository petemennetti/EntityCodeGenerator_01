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


            if (ValidateForm())
            {
                MessageBox.Show("Validation passed! Proceeding...");
               txtCSCode.Text= EntityFileGenerator.CreateEntityFile(
                txtNameSpace.Text,
                txtServer.Text,
                txtDatabase.Text,
                txtTableOrView.Text,
                txtOutputPath.Text

                ); // Call the static method
            }
            else
            {
                MessageBox.Show("Please fill in all required fields.");
            }



           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNameSpace.Text = "MyProject";
            txtServer.Text = ".";
            txtDatabase.Text = "BookStoreDb";
            txtTableOrView.Text = "Authors";
             txtOutputPath.Text = @"c:\dev\" + $"{txtTableOrView.Text}.cs";
            txtCSCode.Text = "C# Entity class:";
        }
        private bool ValidateForm()
        {
            bool valid=true;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.BackColor = Color.LightCoral; // Highlight invalid field
                        valid = false;   
                    }
                    else
                    {
                        textBox.BackColor = Color.White; // Reset to default
                    }
                }
            }

            return valid; // All text boxes are valid
        }
    }
}
