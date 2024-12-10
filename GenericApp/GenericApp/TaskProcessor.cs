using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    internal class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        private TTask task;

        public TaskProcessor(TTask task)
        {
            this.task = task;
        }

        public TResult Execute() 
        {
            return task.Perform();
        }
    }
}
