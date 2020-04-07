using System;
using System.Threading;

namespace Events_Delegates
{
    // 1 - Define Delegate
    // 2 - Define an event based on that delegate
    // 3 - Raise the event
    public class VideoEncoder
    {
        // 1 - Define Delegate
        public delegate void VideoEncodedEventHandler(object source, EventArgs args);

        // 2 - Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Video Encoding..." + video.Title);
            Thread.Sleep(3000);

            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded!=null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}
