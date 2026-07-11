using System;

public class SimpleGoal : Goal
{
    // Attribute
    private bool _isComplete;

    // Constructor for creating a new goal
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Constructor for loading a saved goal
    public SimpleGoal(string name, string description, int points, bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Record the completion of the goal
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }

        return 0;
    }

    // Check if the goal is complete
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Display the goal status
    public override string GetStatus()
    {
        return _isComplete ? "[X]" : "[ ]";
    }

    // Will Convert the goal to a string to use for saving
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }
}