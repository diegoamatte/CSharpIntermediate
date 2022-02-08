using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6___Workflow_Engine
{
    public class Workflow
    {
        private List<IActivity> _activities = new();

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }

        public void RemoveActivity(IActivity activity)
        {
            if (_activities.Contains(activity))
                _activities.Remove(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }
    }
}
