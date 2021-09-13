using System;
using System.Windows.Forms;

namespace Making_an_order
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAboutUs aboutUs = new FormAboutUs();
            aboutUs.Show();
        }

        private void btnMakingAnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTypeOfDelivery typeOfDelivery = new FormTypeOfDelivery();
            typeOfDelivery.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback feedback = new Feedback();
            feedback.Show();
        }
    }
}
