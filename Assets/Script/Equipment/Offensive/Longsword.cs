using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Longsword : Offensive
{
    public Longsword(StatEquipment stat): base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/LongSword");
    }
}
