using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

struct GameCurrency
{
    public int Gold;
    public int Silver;
    public GameCurrency(int gold, int silver)
    { 
        if(silver >= 100)
        {
            gold += silver / 100;
            silver %= 100;
        }
        Gold = gold;
        Silver = silver;
    }

    public static GameCurrency operator +(GameCurrency a, GameCurrency b)
    {
        return new GameCurrency(a.Gold + b.Gold, a.Silver + b.Silver);
    }
    public static GameCurrency operator -(GameCurrency a, GameCurrency b)
    {
        int aTotalMoney = (a.Gold * 100) + a.Silver;
        int bTotalMoney = (b.Gold * 100) + b.Silver;
        if(aTotalMoney < bTotalMoney)
        {
            return new GameCurrency(0, 0);
        }
        else
        {
            return new GameCurrency(0,aTotalMoney-bTotalMoney);
        }
    }
    public static bool operator ==(GameCurrency a, GameCurrency b)
    {
        return a.Gold == b.Gold && a.Silver == b.Silver;
    }
    public static bool operator !=(GameCurrency a, GameCurrency b)
    {
        return !(a == b);
    }
    public override bool Equals(object obj)
    {
        if(obj is GameCurrency g)
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
        return HashCode.Combine(Gold, Silver);
    }
    public static bool operator <(GameCurrency a, GameCurrency b)
    {
        int aTotalMoney = (a.Gold * 100) + a.Silver;
        int bTotalMoney = (b.Gold * 100) + b.Silver;
        return aTotalMoney < bTotalMoney;
    }
    public static bool operator >(GameCurrency a, GameCurrency b)
    {
        int aTotalMoney = (a.Gold * 100) + a.Silver;
        int bTotalMoney = (b.Gold * 100) + b.Silver;
        return aTotalMoney > bTotalMoney;
    }
    public int GetTotalSilver()
    {
        return (Gold * 100) + Silver;
    }
    public override string ToString()
    {
        return $"{Gold}G {Silver}S";
    }
}
