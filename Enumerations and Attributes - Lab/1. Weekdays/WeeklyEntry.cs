﻿using System;

public class WeeklyEntry : IComparable<WeeklyEntry>
{
    private WeekDay weekDay;

    public WeeklyEntry(string weekday, string notes)
    {
        Enum.TryParse(weekday, out this.weekDay);
        this.Notes = notes;
    }

    public WeekDay WeekDay { get; }
    public string Notes { get; private set; }

    public int CompareTo(WeeklyEntry other)
    {
        if (ReferenceEquals(this, other))
        {
            return 0;
        }
        if (ReferenceEquals(null, other))
        {
            return 1;
        }
        var weekDayComparison = weekDay.CompareTo(other.WeekDay);
        if (weekDayComparison != 0)
        {
            return weekDayComparison;
        }
        return string.Compare(Notes, other.Notes, StringComparison.Ordinal);
    }

    public override string ToString()
    {
        return $"{this.WeekDay} - {this.Notes}";
    }
}
