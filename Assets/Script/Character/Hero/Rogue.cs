using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Hero
{
    public Rogue(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Rogue");
    }
}
