using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : Defensive
{
    public Helmet(StatEquipment stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Helmet");
    }
    public override string GetDescription()
    {
        base.GetDescription();
        return "A hat but in steel";
    }
}
