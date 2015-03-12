namespace ConsoleApplication1
{
    internal class ExpressionBodiedMembers
    {
        public double CostPrice { get; set; }

        private double Tax()
        {
            // amazing DB code
            return 1.14;
        }

        public double Price
        {
            get
            {
                return CostPrice * Tax();
            }
        }
    }
}