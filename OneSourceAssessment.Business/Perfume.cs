namespace OneSourceAssessment.Business
{
    public class Perfume : Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Perfume"/> class.
        /// </summary>
        /// <param name="price">The price with taxes.</param>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        public Perfume(decimal price, float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = false, int quantity = 1) : base(price, salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Perfume"/> class.
        /// </summary>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        public Perfume(bool isImported, bool isTaxExempt = false, int quantity = 1) : base(isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Perfume"/> class.
        /// </summary>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        public Perfume(float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = false, int quantity = 1) : base(salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        public Perfume(decimal price, bool isImported, bool isTaxExempt = false, int quantity = 1) : base(price, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Sets the defaults.
        /// </summary>
        private void SetDefaults()
        {
            Name = "Bottle of Perfume";
        }
    }
}