using System;

namespace Exercise2
{
    public class WorkFlowEngine : IWorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var task in workFlow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (Exception)
                {
                    // Logging
                    // Terminate and persist the state of workflow
                    throw;
                }
            }
        }
    }
}
