using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Hero
{
    public Knight(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Knight");
    }
    public override string GetDialogueLine()
    {
        base.GetDialogueLine();
        return "LEEROYYYYYYYYY JENKINS !!";
    }
}
