using System;
using System.ComponentModel;

namespace ConsoleApplication1
{
    internal static class NullPropagation
    {
        public static void Exception(Track track)
        {
            Console.WriteLine("HI! " + track?.Band?.FrontMan?.Name);
        }

        public static void Exception2(Track track)
        {
            var name = string.IsNullOrWhiteSpace(track?.Band?.FrontMan?.Name) ? "Unknown" : track.Band.FrontMan.Name;
            Console.WriteLine("HI! " + name);
        }

        public static void AllTheCeremony(Track track)
        {
            if (track?.Band?.FrontMan?.Name == "Munya")
            {
                Console.WriteLine("HI! " + track.Band.FrontMan.Name);
            }
        }

    }

    internal class NullConditionalEvent : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePain(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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