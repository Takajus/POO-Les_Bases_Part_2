using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rogue : Hero
{
    public Rogue(StatCharacter stat) : base(stat)
    {
        Sprite = Resources.Load<Sprite>("Pictures/Rogue");
    }

    public override string GetDialogueLine()
    {
        base.GetDialogueLine();
        return "I have already steal your money.";
    }
}
