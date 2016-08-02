using System.Globalization;

namespace OneSourceAssessment.Business
{
    public class HeadachePills : Medical
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadachePills"/> class.
        /// </summary>
        /// <param name="price">The price with taxes.</param>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> it means that it is imported.</param>
        /// <param name="isTaxExempt"></param>
        public HeadachePills(decimal price, float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(price, salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadachePills"/> class.
        /// </summary>
        /// <param name="isImported">if set to <c>true</c> it means that it is imported.</param>
        public HeadachePills(bool isImported, bool isTaxExempt = true, int quantity = 1) : base(isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HeadachePills"/> class.
        /// </summary>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> it means that it is imported.</param>
        /// <param name="isTaxExempt"></param>
        public HeadachePills(float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(salesTaxPercentage, importTaxPercentage, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        public HeadachePills(decimal price, bool isImported, bool isTaxExempt = true, int quantity = 1) : base(price, isImported, isTaxExempt, quantity)
        {
            SetDefaults();
        }

        /// <summary>
        /// Sets the defaults.
        /// </summary>
        private void SetDefaults()
        {
            Name = "Packet of Headache Pills";
        }
    }
}