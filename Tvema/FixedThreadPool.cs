using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tvema
{
    class FixedThreadPool
    {
        public ITask Task;

        public enum Priority
        {
            Low = 0,
            Normal = 1,
            High = 2
        };

        public FixedThreadPool(int threadCount)
        {
            
        }
        public bool Execute(Task task, Priority priority)
        {

        }

        public void Stop()
        {

        }
    }

    interface ITask
    {
        void Execute();
    }
}
