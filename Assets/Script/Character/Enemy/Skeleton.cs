using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    public Skeleton(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Skeleton");
    }
}
