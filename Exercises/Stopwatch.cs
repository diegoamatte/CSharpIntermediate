namespace Exercise_1
{
    public class Stopwatch
    {
        private DateTime _start;
        public void Start()
        {
            if (_start != default) throw new InvalidOperationException();
            _start = DateTime.Now;
        }

        public void Stop()
        {
            var duration = _start!= default? DateTime.Now - _start : TimeSpan.Zero;
            _start = default;
            Console.WriteLine(duration);
        }
    }
}
