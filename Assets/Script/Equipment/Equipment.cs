using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    public Sprite sprite { get; protected set; }
    public StatEquipment stat { get; protected set; }

    public Equipment(StatEquipment stat)
    {
        this.stat = stat;
        sprite = null;
    }
    public virtual string GetDescription()
    {
        return "nothing";
    }
}
