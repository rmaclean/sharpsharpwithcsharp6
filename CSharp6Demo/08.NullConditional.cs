using System;
using System.ComponentModel;

namespace ConsoleApplication1
{
    internal static class NullConditional
    {
        public static void PAIN(Track track)
        {
            if (track == null || track.Band == null || track.Band.FrontMan == null || string.IsNullOrWhiteSpace(track.Band.FrontMan.Name))
            {
                return;
            }

            Console.WriteLine(track.Band.FrontMan.Name);
        }
    }

    internal class NullConditionalEvent : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePain(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    internal class Band
    {
        public Member FrontMan { get; set; }
    }

    internal class Member
    {
        public string Name { get; set; }
    }

    internal class Track
    {
        public Band Band { get; set; }
    }
}