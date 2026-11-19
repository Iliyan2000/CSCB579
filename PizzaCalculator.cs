using System;
using System.Collections.Generic;

namespace PizzariaKasa
{
    /// <summary>
    /// Съдържа цялата бизнес логика за изчисляване на цените.
    /// Нарочно е отделена от формата (изискване 3).
    /// </summary>
    public static class PizzaCalculator
    {
        public const decimal ExtraPrice = 1.50m;      // цена на една добавка
        public const decimal DiscountThreshold = 40m; // праг за отстъпка на реда
        public const decimal DiscountRate = 0.10m;    // 10% отстъпка

        /// <summary>
        /// Връща ценовия коефициент според размера.
        /// Малка = 1.00, Средна = 1.25, Семейна = 1.50
        /// </summary>
        public static decimal GetSizeMultiplier(string sizeName)
        {
            switch (sizeName)
            {
                case "Средна": return 1.25m;
                case "Семейна": return 1.50m;
                default: return 1.00m; // Малка
            }
        }

        /// <summary>
        /// Изчислява единичната цена на една пица: базова цена * размер + добавки.
        /// </summary>
        public static decimal CalculateUnitPrice(decimal basePrice, string sizeName, int extrasCount)
        {
            decimal price = basePrice * GetSizeMultiplier(sizeName);
            price += extrasCount * ExtraPrice;
            return price;
        }

        /// <summary>
        /// Изчислява целия ред. Ако сумата надхвърли прага, прилага 10% отстъпка.
        /// </summary>
        public static OrderItem CalculateLine(
            string pizzaName, decimal basePrice, string sizeName,
            int extrasCount, int quantity)
        {
            decimal unit = CalculateUnitPrice(basePrice, sizeName, extrasCount);
            decimal lineTotal = unit * quantity;

            bool discount = lineTotal > DiscountThreshold;
            if (discount)
            {
                lineTotal -= lineTotal * DiscountRate;
            }

            return new OrderItem
            {
                PizzaName = pizzaName,
                SizeName = sizeName,
                Quantity = quantity,
                UnitPrice = unit,
                LineTotal = lineTotal,
                DiscountApplied = discount
            };
        }

        /// <summary>
        /// Обобщава всички позиции чрез обхождане с цикъл (изискване 4).
        /// </summary>
        public static OrderSummary Summarize(IEnumerable<OrderItem> items)
        {
            var summary = new OrderSummary();

            foreach (OrderItem item in items)
            {
                summary.TotalAmount += item.LineTotal;
                summary.TotalPizzas += item.Quantity;

                if (item.LineTotal > summary.MostExpensiveTotal)
                {
                    summary.MostExpensiveTotal = item.LineTotal;
                    summary.MostExpensiveItem = item;
                }
            }

            return summary;
        }
    }

    /// <summary>
    /// Резултат от обобщението на сметката.
    /// </summary>
    public class OrderSummary
    {
        public decimal TotalAmount { get; set; }
        public int TotalPizzas { get; set; }
        public decimal MostExpensiveTotal { get; set; }
        public OrderItem MostExpensiveItem { get; set; }
    }
}
