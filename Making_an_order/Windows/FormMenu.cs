using System.Windows.Forms;
using System;
using TextFileEditor;

namespace Making_an_order
{
    public partial class FormMenu : Form
    { 
        public FormMenu()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            FormTypeOfDelivery f3 = new FormTypeOfDelivery();
            f3.Show();
        }
        public void btnSum_Click(object sender, EventArgs e)
        {
            int summa = 0;
            if (cbMargaret.Checked == true)
                summa += 350;
            if (cbPepperoni.Checked == true)
                summa += 350;
            if (cbPalermo.Checked == true)
                summa += 465;
            if (cbSalami.Checked == true)
                summa += 415;
            if (cbVegano.Checked == true)
                summa += 415;
            if (cbLaMarseillaise.Checked == true)
                summa += 475;
            if (cbTea.Checked == true)
                summa += 115;
            if (cbFanta.Checked == true)
                summa += 115;
            if (cbCocaCola.Checked == true)
                summa += 110;
            if (cbBonAqua.Checked == true)
                summa += 75;
            if (cbLatte.Checked == true)
                summa += 145;
            if (cbJuice.Checked == true)
                summa += 75;
            if (cbApplePie.Checked == true)
                summa += 139;
            if (cbCheesecake.Checked == true)
                summa += 139;
            if (cbCheesecakes.Checked == true)
                summa += 310;
            if (cbFondant.Checked == true)
                summa += 310;
            if (cbMuffin.Checked == true)
                summa += 99;
            if (cbDonut.Checked == true)
                summa += 109;

            tbSum.Text = Convert.ToString(summa);
        }
        private void btnPromoCodeTracking_Click(object sender, EventArgs e)
        {   
            if(String.IsNullOrWhiteSpace(tbFeedback.Text))
            {
                MessageBox.Show("Вы не ввели промокод! Попробуйте снова.");
            }
            else  if (tbFeedback.Text == "HELLO505")
            {
                double sum = Convert.ToDouble(tbSum.Text);
                double dis = sum / 100 * 35;
                double result = sum - dis;
                tbSum.Text = Convert.ToString(result);
                (sender as Button).Enabled = false;
            } 
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tbSum.Text))
            {
                MessageBox.Show("Вы ничего не выбрали!\nВыберите что-нибудь (перед тем как совершить заказ нажмите на кнопку <<Посчитать сумму>>)");
            }
            else {
                Save save = new Save();
                save.SaveCheck(cbMargaret,cbPepperoni,cbPalermo,cbSalami,cbVegano,cbLaMarseillaise,cbTea,cbFanta,cbCocaCola,cbBonAqua,cbLatte,cbJuice,cbApplePie,cbCheesecake,cbCheesecakes,cbFondant,cbMuffin,cbDonut,tbSum,tbFeedback);
                MessageBox.Show("Спасибо за ваш заказ!\nЕсли вы выбрали вид доставки <<Самовывоз>> - заказ оплачивается на кассе.\nПри выборе вида доставки <<Курьер>> - оплата осуществляется курьеру после доставления вашего заказа.");
            Application.Exit();
            }
        }
    }
}
