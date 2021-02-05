using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skeleton : Enemy
{
    public Skeleton(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Skeleton");
    }
    public override string GetDialogueLine()
    {
        base.GetDialogueLine();
        return "You feel like you're going to have a bad time.";
    }
}
