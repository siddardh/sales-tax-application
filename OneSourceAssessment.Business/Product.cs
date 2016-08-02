using System;
using OneSourceAssessment.Business;
using OneSourceAssessment.Contract;

namespace OneSourceAssessment.Business
{ 
    public abstract class Product : IProduct

    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="price">The price with taxes.</param>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
        /// <param name="quantity">Gives the quantity of the product</param>
        protected Product(decimal price, float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt, int quantity)
        {
            IsTaxExempt = isTaxExempt;
            IsImported = isImported;
            Price = price;
            SalesTaxPercentage = salesTaxPercentage;
            ImportTaxPercentage = importTaxPercentage;
            Quantity = quantity;
            SetPriceWithTaxes(price);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
		/// <param name="quantity">Gives the quantity of the product</param>

        protected Product(bool isImported, bool isTaxExempt, int quantity) : this(0, Constants.DEFAULT_SALES_TAX_PERCENTAGE, Constants.DEFAULT_IMPORT_TAX_PERCENTAGE, isImported, isTaxExempt, quantity)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="salesTaxPercentage">The sales tax percentage.</param>
        /// <param name="importTaxPercentage">The import tax percentage.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
		/// <param name="quantity">Gives the quantity of the product</param>
		protected Product(float salesTaxPercentage, float importTaxPercentage, bool isImported, bool isTaxExempt, int quantity) : this(0, Constants.DEFAULT_SALES_TAX_PERCENTAGE, Constants.DEFAULT_IMPORT_TAX_PERCENTAGE, isImported, isTaxExempt, quantity)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Product"/> class.
        /// </summary>
        /// <param name="price">The price with taxes.</param>
        /// <param name="isImported">if set to <c>true</c> [is imported].</param>
        /// <param name="isTaxExempt">if set to <c>true</c> [is tax exempt].</param>
		/// <param name="quantity">Gives the quantity of the product</param>
        protected Product(decimal price, bool isImported, bool isTaxExempt, int quantity) : this(price, Constants.DEFAULT_SALES_TAX_PERCENTAGE, Constants.DEFAULT_IMPORT_TAX_PERCENTAGE, isImported, isTaxExempt, quantity)
        {
            
        }

       public bool IsTaxExempt { get; set; }
       public bool IsImported { get; set; }
       public string Name { get; set; }
       public int Quantity { get; set; }
       public decimal PriceWithTaxes { get; set; }
       public decimal Price { get; set; }
       public float SalesTaxPercentage { get; set; }
       public float ImportTaxPercentage { get; set; }

        /// <summary>
        /// Gets the tax amount.
        /// </summary>
        /// <returns></returns>
        public virtual decimal GetTaxAmount()
        {
            return PriceWithTaxes - Price;
        }


        /// <summary>
        /// Sets the price with taxes.
        /// </summary>
        /// <param name="price">The price with taxes.</param>
        public virtual void SetPriceWithTaxes(decimal price)
        {
            Price = price;
            
            var totalTax = 0f;
            if (IsTaxExempt == false)
            {
                totalTax += SalesTaxPercentage;
            }

            if (IsImported)
            {
                totalTax += ImportTaxPercentage;
            }
			// total price for different quantity
            decimal totalPrice = Quantity * Price;

            if (totalTax == 0)
            {
                PriceWithTaxes = totalPrice;
            }
            else
            {
				PriceWithTaxes = RoundToNearestFive(totalPrice + Convert.ToDecimal(totalTax) * totalPrice / 100);
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0}{3} {1} : {2}", Quantity, Name, PriceWithTaxes, IsImported ? " imported" : string.Empty);
        }


		/// <summary>
		/// Rounds to nearest five.
		/// </summary>
		/// <returns>The to nearest five.</returns>
		/// <param name="inputValue">Input value.</param>
        protected decimal RoundToNearestFive(decimal inputValue)
        {
            inputValue = Math.Round(inputValue, 2);
            int lastDigitAfterDecimal = Convert.ToInt32(inputValue * 100 % 10);

            if (lastDigitAfterDecimal > 0 && lastDigitAfterDecimal < 5)
            {
                return inputValue + (0.05m - (inputValue - Math.Floor(inputValue)) % 0.05m);
            }
            return inputValue;
        }
    }
}