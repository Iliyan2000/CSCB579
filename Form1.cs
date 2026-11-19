using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PizzariaKasa
{
    public partial class Form1 : Form
    {
        // Описва елемент от падащия списък: име + базова цена.
        private class PizzaType
        {
            public string Name { get; set; }
            public decimal BasePrice { get; set; }

            public override string ToString()
            {
                return string.Format("{0} – {1:0.00} лв.", Name, BasePrice);
            }
        }

        // Съхранява всички добавени позиции, за да ги обобщим после.
        private readonly List<OrderItem> orders = new List<OrderItem>();

        public Form1()
        {
            InitializeComponent();
            LoadPizzas();
        }

        /// <summary>
        /// Зарежда менюто в ComboBox-а.
        /// </summary>
        private void LoadPizzas()
        {
            cmbPizza.Items.Add(new PizzaType { Name = "Маргарита", BasePrice = 10m });
            cmbPizza.Items.Add(new PizzaType { Name = "Капричоза", BasePrice = 13m });
            cmbPizza.Items.Add(new PizzaType { Name = "Пеперони", BasePrice = 14m });
            cmbPizza.Items.Add(new PizzaType { Name = "Куатро Формаджи", BasePrice = 16m });
            cmbPizza.SelectedIndex = 0;
        }

        /// <summary>
        /// Връща името на избрания размер според маркирания RadioButton.
        /// </summary>
        private string GetSelectedSize()
        {
            if (rbMedium.Checked) return "Средна";
            if (rbFamily.Checked) return "Семейна";
            return "Малка";
        }

        /// <summary>
        /// Преброява маркираните добавки.
        /// </summary>
        private int CountExtras()
        {
            int count = 0;
            if (chkCheese.Checked) count++;
            if (chkBacon.Checked) count++;
            if (chkMushrooms.Checked) count++;
            if (chkOlives.Checked) count++;
            return count;
        }

        /// <summary>
        /// Бутон „Добави към сметката“ – валидация + изчисление + добавяне в ListBox.
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Проверка за избрана пица (при DropDownList почти винаги има избор).
            if (!(cmbPizza.SelectedItem is PizzaType selectedPizza))
            {
                MessageBox.Show("Моля, изберете вид пица.",
                    "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Валидация на броя чрез int.TryParse (изискване 2).
            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity))
            {
                MessageBox.Show("Броят пици трябва да е цяло число.",
                    "Невалиден вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Броят пици трябва да е положително число (поне 1).",
                    "Невалиден вход", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Изчислението е изнесено в помощния клас (изискване 3).
            OrderItem item = PizzaCalculator.CalculateLine(
                selectedPizza.Name,
                selectedPizza.BasePrice,
                GetSelectedSize(),
                CountExtras(),
                quantity);

            orders.Add(item);
            lstOrders.Items.Add(item.ToString());

            txtQuantity.Clear();
            txtQuantity.Focus();
        }

        /// <summary>
        /// Бутон „Приключи сметка / Обобщение“ – обхожда позициите с цикъл.
        /// </summary>
        private void btnSummary_Click(object sender, EventArgs e)
        {
            if (orders.Count == 0)
            {
                MessageBox.Show("Сметката е празна. Добавете поне една позиция.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Обобщението се прави чрез цикъл в помощния клас (изискване 4).
            OrderSummary summary = PizzaCalculator.Summarize(orders);

            string mostExpensive = summary.MostExpensiveItem != null
                ? summary.MostExpensiveItem.ToString()
                : "-";

            string message =
                string.Format("Обща сума за плащане: {0:0.00} лв.\n", summary.TotalAmount) +
                string.Format("Общ брой поръчани пици: {0}\n\n", summary.TotalPizzas) +
                string.Format("Най-скъпа единична позиция:\n{0}", mostExpensive);

            MessageBox.Show(message, "Обобщение на сметката",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Бутон „Нова сметка“ – нулира списъка.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            orders.Clear();
            lstOrders.Items.Clear();
            txtQuantity.Clear();
            cmbPizza.SelectedIndex = 0;
            rbSmall.Checked = true;
            chkCheese.Checked = false;
            chkBacon.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
        }
    }
}
