class Swimming : Activity
{
    private int _laps; // number of laps
    private const double LapDistance = 0.05; // each lap is 50 meters or 0.05 km

    public Swimming(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance() => _laps * LapDistance;

    public override double GetSpeed() => GetDistance() / (Duration / 60.0);

    public override double GetPace() => Duration / GetDistance();
}