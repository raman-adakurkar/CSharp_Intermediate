using System;

namespace exercise6
{
    public class SendEmailToOwner : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email to Owner...");
        }
    }
}
