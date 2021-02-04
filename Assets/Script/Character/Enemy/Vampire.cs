using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : Enemy
{
    public Vampire(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Vampire");
    }
}
