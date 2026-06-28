using System;

public abstract class Goal
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Getters
    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }

    // Methods every goal must have
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStatus();

    public abstract string GetStringRepresentation();

    // Display goal information
    public virtual string GetDetailsString()
    {
        return $"{GetStatus()} {_name} ({_description})";
    }
}