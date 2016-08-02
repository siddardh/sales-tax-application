namespace OneSourceAssessment.Business
{
    public abstract class Food : Product
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class.
        /// </summary>
        /// <param name="price">The price with taxes.</param>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        protected Food(decimal price, float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(price, salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class.
        /// </summary>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
		/// <param name="quantity""> </param>
        protected Food(bool isImported, bool isTaxExempt = true, int quantity = 1) : base(isImported, isTaxExempt, quantity)
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Food"/> class.
        /// </summary>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        protected Food(float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
        }

        protected Food(decimal price, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(price, isImported, isTaxExempt, quantity)
        {
        }
    }
}