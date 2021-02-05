using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Longsword : Offensive
{
    public Longsword(StatEquipment stat): base(stat)
    {
        Sprite = Resources.Load<Sprite>("Pictures/LongSword");
    }
    public override string GetDescription()
    {
        base.GetDescription();
        return "A big big sword";
    }
}
