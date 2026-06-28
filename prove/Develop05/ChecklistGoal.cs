using System;

public class ChecklistGoal : Goal
{
    // Attributes specific to checklist goals
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor for a new checklist goal
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    // Constructor for loading from a file
    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus)
        : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // Record progress on the goal
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            // If goal just reached completion, give bonus
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }

            return _points;
        }

        return 0;
    }

    // Check if goal is complete
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    
    public override string GetStatus()
    {
        if (IsComplete())
        {
            return "[X]";
        }
        else
        {
            return $"[{_amountCompleted}/{_target}]";
        }
    }

    // Save to file
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_amountCompleted},{_target},{_bonus}";
    }
}