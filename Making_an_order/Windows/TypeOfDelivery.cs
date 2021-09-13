using System;
using System.Windows.Forms;

namespace Making_an_order
{
    public partial class FormTypeOfDelivery : Form
    {
        public FormTypeOfDelivery()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMainMenu mainMenu = new FormMainMenu();
            mainMenu.Show();
        }
        private void btnFurther_Click(object sender, EventArgs e)
        {
            if (rbPickUpService.Checked)
            {
                this.Hide();
                FormMenu formMenu = new FormMenu();
                formMenu.Show();

            }
            else
            {
                this.Hide();
                FormAddress formAddress = new FormAddress();
                formAddress.Show();
            }
        }
    }
}
