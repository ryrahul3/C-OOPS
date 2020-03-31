using System;

namespace Exercise2
{
    public class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }
}
