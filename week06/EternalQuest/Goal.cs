public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public int Points => _points; // Propiedad pública para acceder a los puntos

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();

    public virtual string GetStringRepresentation()
    {
        return $"{GetType().Name}|{_shortName}|{_description}|{_points}";
    }
}


