using BenchmarkDotNet.Attributes;
using System.Threading;
using System.Threading.Tasks;

namespace Benchmark.Net
{
    public class TaskVsThread
    {
        public int loopCount = 100;
        public void SimpleLoop()
        {
            for (int i = 0; i < 100; i++)
            {
                
            }
        }

        [Benchmark]
        public void Threads()
        {
            var thread = new Thread(SimpleLoop);

            thread.Start();
        }

        [Benchmark]
        public void Tasks()
        {
            var task = new Task(SimpleLoop);
            task.Start();
        }

        [Benchmark]
        public void TaskFactory()
        {
            Task.Factory.StartNew(SimpleLoop);
        }

        [Benchmark]
        public void ThreadPools()
        {
            ThreadPool.QueueUserWorkItem(o => SimpleLoop());
        }
    }
}