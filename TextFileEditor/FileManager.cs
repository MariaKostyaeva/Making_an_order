using System.Windows.Forms;
using System.IO;

namespace TextFileEditor
{
    public class Save
    {
        public void SaveCheck(CheckBox cbMargaret, CheckBox cbPepperoni, CheckBox cbPalermo, CheckBox cbSalami, CheckBox cbVegano, CheckBox cbLaMarseillaise, CheckBox cbTea, CheckBox cbFanta, CheckBox cbCocaCola, CheckBox cbBonAqua, CheckBox cbLatte, CheckBox cbJuice, CheckBox cbApplePie, CheckBox cbCheesecake, CheckBox cbCheesecakes, CheckBox cbFondant, CheckBox cbMuffin, CheckBox cbDonut, TextBox tbSum, TextBox tbFeedback)
        {
            SaveFileDialog saveCheck = new SaveFileDialog();

            if (saveCheck.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveCheck.FileName);
                sw.WriteLine("Пиццерия <<Папа Луи>>");
                sw.WriteLine("---------------------");
                sw.WriteLine("Кассовый чек");
                sw.WriteLine("---------------------");
                if (cbMargaret.Checked == true)
                {
                    sw.WriteLine("Маргарита 1шт." + " " + "350 p.");
                }
                if (cbPepperoni.Checked == true)
                {
                    sw.WriteLine("Пепперони 1шт." + " " + "350 р.");
                }
                if (cbPalermo.Checked == true)
                {
                    sw.WriteLine("Палермо 1шт." + " " + "465 р.");
                }
                if (cbSalami.Checked == true)
                {
                    sw.WriteLine("Салями 1шт." + " " + "415 р.");
                }
                if (cbVegano.Checked == true)
                {
                    sw.WriteLine("Vegano 1шт." + " " + "415 р.");
                }
                if (cbLaMarseillaise.Checked == true)
                {
                    sw.WriteLine("Марсельеза 1шт." + " " + "475 р.");
                }
                if (cbTea.Checked == true)
                {
                    sw.WriteLine("<<FuseTea>> Зеленый чай с манго и ромашкой 0.5л" + " " + "115 р.");
                }
                if (cbFanta.Checked == true)
                {
                    sw.WriteLine("Fanta 0.5л" + " " + "115 р.");
                }
                if (cbCocaCola.Checked == true)
                {
                    sw.WriteLine("Coca-Cola 0.5л" + " " + "110 р.");
                }
                if (cbBonAqua.Checked == true)
                {
                    sw.WriteLine("<<BonAqua>> негаз. 0.5л" + " " + "75 р.");
                }
                if (cbLatte.Checked == true)
                {
                    sw.WriteLine("Кофе Латте 0.4л" + " " + "145 р.");
                }
                if (cbJuice.Checked == true)
                {
                    sw.WriteLine("Апельсиновый сок <<Rich>> 0.3л" + " " + "75 р.");
                }
                if (cbApplePie.Checked == true)
                {
                    sw.WriteLine("Яблочный пирог 200г" + " " + "139 р.");
                }
                if (cbCheesecake.Checked == true)
                {
                    sw.WriteLine("Чизкейк <<New York>> 200г" + " " + "139 р.");
                }
                if (cbCheesecakes.Checked == true)
                {
                    sw.WriteLine("Сырники с малиновым вареньем 4шт." + " " + "310 р.");
                }
                if (cbFondant.Checked == true)
                {
                    sw.WriteLine("Фонданы 2шт." + " " + "310 р.");
                }
                if (cbMuffin.Checked == true)
                {
                    sw.WriteLine("Маффин <<Три шоколада>> 1шт." + " " + "99 р.");
                }
                if (cbDonut.Checked == true)
                {
                    sw.WriteLine("Пончик клубничный 2шт." + " " + "109 р.");
                }
                if (tbFeedback.Text == "HELLO505")
                {
                    sw.WriteLine("Вы использовали промокод, который дает скидку 35%.");
                }
                sw.WriteLine("Итог:" + " " + tbSum.Text + " " + "р.");
                sw.WriteLine("---------------------");
                sw.WriteLine("СПАСИБО ЗА ПОКУПКУ!");
                sw.Close();
            }
        }
        public void SaveFeedback(TextBox tbFeedback)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            File.WriteAllText(sfd.FileName, tbFeedback.Text);
        }
    }
}