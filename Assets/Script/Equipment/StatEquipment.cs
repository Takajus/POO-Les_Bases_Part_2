using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct StatEquipment
{
    public string name;
    public int marketValue;
    public int attackPower;
    public int defensePower;

    public StatEquipment(string name, int marketValue = 100, int attackPower = 10, int defensePower = 20)
    {
        this.name = name;
        this.marketValue = marketValue;
        this.attackPower = attackPower;
        this.defensePower = defensePower;
    }
}
