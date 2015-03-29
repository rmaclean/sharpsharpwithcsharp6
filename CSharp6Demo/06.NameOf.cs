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
                RaisePropertyChanged(nameof(Age));
            }
        }

        public static void OldPain()
        {
            var type = Type.GetType(nameof(Track));
        }

        private void RaisePropertyChanged(string propertyChanged)
        {
            if (propertyChanged == null)
            {
                throw new ArgumentNullException(nameof(propertyChanged));
            }

            // do stuff
        }
    }
}