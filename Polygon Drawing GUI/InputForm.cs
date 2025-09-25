namespace Polygon_Drawing_GUI
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SidesLabel_Click(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            Form DisplayForm = new DisplayForm(this, (double)this.RadiusBox.Value, (int)this.SideInput.Value);
            Console.WriteLine(this.Text);

            DisplayForm.Show();
            this.Hide();

        }

        private void RadiusBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
