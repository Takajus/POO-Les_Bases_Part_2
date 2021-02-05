﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plastron : Defensive
{
    public Plastron(StatEquipment stat) : base(stat)
    {
        Sprite = Resources.Load<Sprite>("Pictures/Plastron");
    }
    public override string GetDescription()
    {
        base.GetDescription();
       return "Mincraft Plastron";
    }
}
