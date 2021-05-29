using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new VideoEncoder());
            workFlow.Add(new SendEmailToOwner());
            workFlow.Add(new VideoProcessor());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);
            
            Console.WriteLine() ;
        }
    }
}
