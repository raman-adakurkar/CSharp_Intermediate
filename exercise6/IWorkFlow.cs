using System;
using System.Collections.Generic;

namespace exercise6
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}