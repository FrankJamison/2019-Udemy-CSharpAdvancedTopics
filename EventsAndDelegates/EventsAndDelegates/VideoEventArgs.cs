using System;

namespace EventsAndDelegates
{
    // Data about video encoded
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
}