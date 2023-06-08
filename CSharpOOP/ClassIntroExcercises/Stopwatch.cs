using System;

namespace CSharpOOP.ClassIntroExcercises
{
    public class Stopwatch
    {
        private bool _running;
        private DateTime _startedOn;

        public void Start()
        {
            if (_running)
            {
                throw new InvalidOperationException("The stopwatch is already on");
            }
            _running = true;
            _startedOn = DateTime.Now;
        }
        public void Stop()
        {
            var _duration = DateTime.Now - _startedOn;
            _running = false;
            Console.WriteLine("Duration: " +_duration.ToString());
        }
    }
}
