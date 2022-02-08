using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6___Workflow_Engine
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            workflow.GetActivities().ToList()
                .ForEach(activity => activity.Execute());
        }
    }
}
