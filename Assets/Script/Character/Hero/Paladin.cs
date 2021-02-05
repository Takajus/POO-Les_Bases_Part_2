using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Hero
{
    public Paladin(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Paladin");
    }
    public override string GetDialogueLine()
    {
        base.GetDialogueLine();
        return "I will pray for you !";
    }
}
