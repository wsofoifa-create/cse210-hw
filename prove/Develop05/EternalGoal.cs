using System;

public class EternalGoal : Goal
{
    // Constructor for creating a new eternal goal
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // Record the event and give points every time
    public override int RecordEvent()
    {
        return _points;
    }

    // Eternal goals are eternal, never ending
    public override bool IsComplete()
    {
        return false;
    }

    // Display an unchecked box since the goal is never completed
    public override string GetStatus()
    {
        return "[ ]";
    }

    // Convert the goal to a string for saving
    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_name},{_description},{_points}";
    }
}