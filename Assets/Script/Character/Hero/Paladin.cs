using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Hero
{
    public Paladin(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Paladin");
    }
}
