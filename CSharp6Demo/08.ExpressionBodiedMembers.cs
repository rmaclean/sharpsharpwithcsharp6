using System.ComponentModel;

namespace ConsoleApplication1
{
    internal class ExpressionBodiedMembers
    {
        public double CostPrice { get; set; }

        private double Tax() => 1.14;

        public double Price => CostPrice * Tax();
    }

    internal class ExpressionBodiedMethod : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePain(string propertyName) =>  PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}