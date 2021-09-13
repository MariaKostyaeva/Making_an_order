using System;
using System.Windows.Forms;
using TextFileEditor;

namespace Making_an_order
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();  
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {            
            if (String.IsNullOrWhiteSpace(tbFeedback.Text))
            {
                MessageBox.Show("Вы не оставили комментарий. Промокод недоступен.");
            }
            else
            {
                Save save = new Save();
                save.SaveFeedback(tbFeedback);
                MessageBox.Show("Спасибо за ваш комментарий!\nПромокод: HELLO505\nСкидка 35% на ваш заказ по промокоду!");
            }
        }
    }
}
