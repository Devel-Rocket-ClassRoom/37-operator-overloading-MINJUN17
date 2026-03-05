using System;
using System.Collections.Generic;
using System.Text;

struct GameTime
{
    public int Hour;
    public int Minutes;
    public int Seconds;

    public GameTime(int hour, int minutes, int seconds)
    {
        if (seconds >= 60)
        {
            minutes += seconds / 60;
            seconds %= 60;
        }
        if (minutes >= 60)
        {
            hour += minutes / 60;
            minutes %= 60;
        }
        Hour = hour; 
        Minutes = minutes; 
        Seconds = seconds;
    }
    public static GameTime operator +(GameTime a, GameTime b)
    {
        return new GameTime(a.Hour + b.Hour, a.Minutes + b.Minutes, a.Seconds + b.Seconds);
    }
    public static GameTime operator *(GameTime a, int i)
    {
        int totalSeconds = ((a.Hour * 3600) + (a.Minutes * 60) + a.Seconds) * i;
        return new GameTime(0,0, totalSeconds);
    }
    public static GameTime operator *(int i, GameTime a)
    {
        return a * i;
    }
    public static GameTime operator -(GameTime a, GameTime b)
    {
        int aSeconds = (a.Hour * 3600) + (a.Minutes * 60) + a.Seconds;
        int bSeconds = (b.Hour * 3600) + (b.Minutes * 60) + b.Seconds;
        if (aSeconds < bSeconds)
        {
            return new GameTime(0, 0, 0);
        }
        else
        {
            return new GameTime(0,0,aSeconds-bSeconds);
        }
    }
    public static bool operator ==(GameTime a, GameTime b)
    {
        return a.Hour == b.Hour && a.Minutes == b.Minutes && a.Seconds == b.Seconds;
    }
    public static bool operator !=(GameTime a, GameTime b)
    {
        return !(a == b);
    }
    public override bool Equals(object obj)
    {
        if (obj is GameTime g)
        {
            return this == g;
        }
        else
        {
            return false;
        }
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(Hour, Minutes, Seconds);
    }
    public static bool operator <(GameTime a, GameTime b)
    {
        int aSeconds = (a.Hour * 3600) + (a.Minutes * 60) + a.Seconds;
        int bSeconds = (b.Hour * 3600) + (b.Minutes * 60) + b.Seconds;
        return aSeconds < bSeconds;
    }
    public static bool operator >(GameTime a, GameTime b)
    {
        int aSeconds = (a.Hour * 3600) + (a.Minutes * 60) + a.Seconds;
        int bSeconds = (b.Hour * 3600) + (b.Minutes * 60) + b.Seconds;
        return aSeconds > bSeconds;
    }
    public override string ToString()
    {
        return $"{Hour}h {Minutes}m {Seconds}s";
    }
    public int GetTotalSeconds()
    {
        int totalSeconds = ((Hour * 3600) + (Minutes * 60) + Seconds);
        return totalSeconds;
    }
}
