using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : Offensive
{
    public Spear(StatEquipment stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Spear");
    }
}
