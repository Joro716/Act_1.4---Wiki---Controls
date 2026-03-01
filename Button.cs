namespace Act_1._4___Wiki___Controls
{
    public partial class Button : Form
    {
        public Button()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Al fer click al boto obre una finestra que posa Hola
            MessageBox.Show("Hola");
        }
    }
}
