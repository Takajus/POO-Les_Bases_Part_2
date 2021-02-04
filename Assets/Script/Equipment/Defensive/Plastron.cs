using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plastron : Defensive
{
    public Plastron(StatEquipment stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Plastron");
    }
}
