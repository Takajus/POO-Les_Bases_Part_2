﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dagger : Offensive
{
    public Dagger(StatEquipment stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Dagger");
    }
    public override string GetDescription()
    {
        base.GetDescription();
        return "A tiny litle Blade";
    }
}
