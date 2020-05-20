using System;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace c_event
{
    public class Calculator
    {
        private ManualResetEventSlim _mEvent;

        public int Result { get; private set; }

        public Calculator(ManualResetEventSlim ev)
        {
            _mEvent = ev;
        }

        public void Calculation(int x, int y)
        {
            WriteLine($"Task {Task.CurrentId} starts addition after 3 second for " +x +" and " + y + " on " +DateTime.Now);
            Task.Delay(new Random().Next(3000)).Wait();
            Result = x + y;

            // signal the event-completed!
            WriteLine($"calculation {Task.CurrentId} is ready on "+DateTime.Now);
            _mEvent.Set();
        }
    }

}