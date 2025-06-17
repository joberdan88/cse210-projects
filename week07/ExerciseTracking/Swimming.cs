public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => (_laps * 50) / 1000;
    public override double GetSpeed() => (GetDistance() / base._duration) * 60; 
    public override double GetPace() => base._duration / GetDistance();
}