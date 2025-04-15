public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals do not track completion or progress, so no action is needed here.
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never considered complete.
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description})";
    }
}