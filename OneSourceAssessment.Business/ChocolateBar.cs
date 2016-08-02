namespace OneSourceAssessment.Business
{
    public class ChocolateBar : Food
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChocolateBar"/> class.
        /// </summary>
        /// <param name="price">The price with taxes.</param>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        public ChocolateBar(decimal price, float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(price, salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChocolateBar"/> class.
        /// </summary>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        public ChocolateBar(bool isImported, bool isTaxExempt = true, int quantity = 1) : base(isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChocolateBar"/> class.
        /// </summary>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        public ChocolateBar(float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        public ChocolateBar(decimal price, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(price, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Sets the defaults.
        /// </summary>
        private void SetDefaults()
        {
            Name = "Chocolate Bar";
        }
    }
}