using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Defensive
{
    public Shield(StatEquipment stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Shield");
    }
    public override void ReadDescription()
    {
        base.ReadDescription();
        Debug.Log("Wait you never saw a shield !?");
    }
}
