using System;

namespace ConsoleApplication1
{
    internal class NameOf
    {
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

        public static void OldPain()
        {
            var type = Type.GetType("Track");
        }

        private void RaisePropertyChanged(string propertyChanged)
        {
            if (propertyChanged == null)
            {
                throw new ArgumentNullException("propertyChanged");
            }

            // do stuff
        }
    }
}