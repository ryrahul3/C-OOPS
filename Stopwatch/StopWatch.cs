using System;

namespace Exercise3
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;
        public void Start()
        {
            if (_running)
                throw new InvalidOperationException("Stopwatch is runnig");

            _startTime = DateTime.Now;
            _running = true;
        }
        public void Stop()
        {
            if (!_running)
                throw new InvalidOperationException("Stopwatch is already stopped.");

            _endTime = DateTime.Now;
            _running = false;
        }

        public TimeSpan GetInterval()
        {
            return _endTime - _startTime;
        }
    }
}
