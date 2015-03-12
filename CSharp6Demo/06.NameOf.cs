using System;
using System.ComponentModel;

namespace ConsoleApplication1
{
    internal class NameOf : INotifyPropertyChanged
    {

        public static void OldPain()
        {
            var type = Type.GetType("Track");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyChanged)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyChanged));
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                RaisePropertyChanged("Age");
            }
        }

    }
}