using System;

namespace Events_Delegates
{
    public class MailService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("Sending Email");
        }
    }
}
