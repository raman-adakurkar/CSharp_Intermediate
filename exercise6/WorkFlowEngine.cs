namespace exercise6
{
    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach(var t in workFlow.GetTasks())
            {
                t.Execute();
            }
        }
    }
}
