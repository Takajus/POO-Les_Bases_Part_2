using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    public StatEquipment stat { get; protected set; }

    public Equipment(StatEquipment stat)
    {
        this.stat = stat;
    }

    ~Equipment()
    {
        Debug.Log("Equipment Destroy!!!");
    }
}
