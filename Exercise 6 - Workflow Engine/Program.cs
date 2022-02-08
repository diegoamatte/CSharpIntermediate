using Exercise_6___Workflow_Engine;

var activity = new ActivityExample();
var workflow = new Workflow();
workflow.AddActivity(activity);
workflow.AddActivity(activity);

var workflowEngine = new WorkflowEngine();
workflowEngine.Run(workflow);
