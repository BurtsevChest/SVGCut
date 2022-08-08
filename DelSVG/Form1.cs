using System.Text.RegularExpressions;

namespace DelSVG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((textBox1.Text == "") || (textBox2.Text == ""))
            {
                MessageBox.Show("Заполните поля!");
            }
            else
            {
                string dirPath = textBox1.Text;
                string del = textBox2.Text;
                if (Directory.Exists(dirPath))
                {
                    string[] files = Directory.GetFiles(dirPath, "*.svg");
                    for (int i = 0; i < files.Length; i++)
                    {
                        string text = File.ReadAllText(@files[i]);
                        Regex rgx = new Regex(del);
                        string newFile = rgx.Replace(text, "");
                        File.WriteAllText(@files[i], newFile);
                    }
                    MessageBox.Show("Готово!");
                    textBox2.Text = "";
                }
            }
            
        }
    }
}