using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Offensive
{
    public Spear(StatEquipment stat) : base(stat)
    {
        Sprite = Resources.Load<Sprite>("Pictures/Spear");
    }
    public override string GetDescription()
    {
        base.GetDescription();
        return "Juste a long stick with a blade";
    }
}
