using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct StatEquipment
{
    public string name;
    public int marketValue;
    public int attackPower;
    public int defensePower;

    public StatEquipment(string name)
    {
        this.name = name;
        this.marketValue = Random.Range(100, 801);
        this.attackPower = Random.Range(5, 21);
        this.defensePower = Random.Range(5, 21);
    }
}
