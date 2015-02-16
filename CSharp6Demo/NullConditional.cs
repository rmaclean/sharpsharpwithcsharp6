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

        public static void YAY(Track track)
        {
            if (string.IsNullOrWhiteSpace(track?.Band?.FrontMan?.Name))
            {
                return;
            }

            Console.WriteLine(track.Band.FrontMan.Name);
        }



        //public event PropertyChangedEventHandler PropertyChanged;
        //public void YAYXAML(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName);
        //}
    }

    class Track
    {
        public Band Band { get; set; }
    }

    class Band
    {
        public Member FrontMan { get; set; }
    }

    class Member
    {
        public string Name { get; set; }
    }
}