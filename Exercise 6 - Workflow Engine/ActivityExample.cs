using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6___Workflow_Engine
{
    public class ActivityExample : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing activity 1");
        }
    }
}
