using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tvema
{
    class FixedThreadPool 
    {
        public ITask Task;

        #region public enum Priority
        public enum Priority
        {
            Low = 0,
            Normal = 1,
            High = 2
        };

        #endregion
        #region public FixedThreadPool
        public FixedThreadPool(int threadCount)
        {
            
        }
        #endregion
        #region public bool Execute
        public bool Execute(Task task, Priority priority)
        {

        }
        #endregion
        #region public void Stop
        public void Stop()
        {

        }
        #endregion

        #region InnerInterface

        interface InnerInterface
        {
            bool Execute(Task task, Priority priority);
            void Stop();
        }

        #endregion
    }

    #region interface ITask
    interface ITask
    {
        void Execute();
    }
    #endregion

}
