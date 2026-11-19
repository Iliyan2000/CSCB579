using System;

namespace PizzariaKasa
{
    /// <summary>
    /// Представя един добавен ред (позиция) в сметката.
    /// </summary>
    public class OrderItem
    {
        public string PizzaName { get; set; }
        public string SizeName { get; set; }
        public int Quantity { get; set; }

        // Единична цена на една пица (с размер и добавки, без отстъпка за реда).
        public decimal UnitPrice { get; set; }

        // Крайна цена за целия ред (брой * единична цена, вече с евентуална отстъпка).
        public decimal LineTotal { get; set; }

        // Дали за реда е приложена отстъпка от 10%.
        public bool DiscountApplied { get; set; }

        public override string ToString()
        {
            string discountText = DiscountApplied ? "  [-10% отстъпка]" : "";
            return string.Format(
                "{0} ({1}) x{2}  @ {3:0.00} лв.  =  {4:0.00} лв.{5}",
                PizzaName, SizeName, Quantity, UnitPrice, LineTotal, discountText);
        }
    }
}
