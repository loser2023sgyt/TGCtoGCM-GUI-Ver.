namespace TGCtoGCM_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.tgc|";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(dialog.FileName);
            }
            
        }
    }
}