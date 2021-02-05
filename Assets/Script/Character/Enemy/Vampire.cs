﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : Enemy
{
    public Vampire(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Vampire");
    }
    public override void SaySomthing()
    {
        base.SaySomthing();
        Debug.Log("Your blood smells good.");
    }
}
