using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment
{
    public Sprite Sprite { get; protected set; }
    public StatEquipment Stat { get; protected set; }

    public Equipment(StatEquipment stat)
    {
        this.Stat = stat;
        Sprite = null;
    }
    public virtual string GetDescription()
    {
        return "nothing";
    }
}
