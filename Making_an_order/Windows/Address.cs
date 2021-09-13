using System;
using System.Windows.Forms;

namespace Making_an_order
{
    public partial class FormAddress : Form
    {
        string[] city =
       {
            "Краснодар",
            "Москва",
            "Сочи",
            "Санкт-Петербург",
            "Пенза",
            "Астрахань"
        };
        public FormAddress()
        {
            InitializeComponent();
            int i;
            for (i = 0; i < 3; i++)
            {
                cbAddress.Items.Add(city[i]);
            }
        }
        private void btnAdFurther_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbAddress.Text))
            {
                MessageBox.Show("Вы не выбрали город.");
            }
            else if (String.IsNullOrWhiteSpace(tbAddress.Text))
            {
                MessageBox.Show("Вы не ввели улицу и номер дома/квартиры, попробуйте снова!");
            }
            else
            {
                this.Hide();
                FormMenu menu = new FormMenu();
                menu.Show();
            }
        }
        private void btnAdBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTypeOfDelivery typeOfDelivery = new FormTypeOfDelivery();
            typeOfDelivery.Show();
        }
    }
}
