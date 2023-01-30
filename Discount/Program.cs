


namespace Discount
{
    internal class Customer
    {
    public int CustomerID { get; set; }
    public string Name { get; set; }

    //public decimal Discount { get; set; }

    private decimal _discount;

    public decimal Discount
        {
        get { return _discount; }
        set
            {
            if (value >= 0 && value <= 1)
                {
                _discount = value;
                }
            else
                {
                throw new ArgumentOutOfRangeException("Discount must 0 to 1 (0% to 100%)");
                }
            }
        }



    }
}
