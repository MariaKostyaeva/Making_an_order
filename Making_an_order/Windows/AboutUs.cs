using System;
using System.IO;

namespace Making_an_order
{
    public partial class FormAboutUs : System.Windows.Forms.Form
    {
        public FormAboutUs()
        {
            InitializeComponent();
            using(StreamReader aboutUs = new StreamReader("о нас.txt", System.Text.Encoding.GetEncoding(1251)))
            {
                string word;
                while((word = aboutUs.ReadLine()) != null)
                {
                    lInfo.Text = (word + Environment.NewLine);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }
    }
}
