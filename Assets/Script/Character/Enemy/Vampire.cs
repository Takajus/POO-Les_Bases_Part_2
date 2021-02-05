using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vampire : Enemy
{
    public Vampire(StatCharacter stat) : base(stat)
    {
        Sprite = Resources.Load<Sprite>("Pictures/Vampire");
    }
    public override string GetDialogueLine()
    {
        base.GetDialogueLine();
        return "Your blood smells good.";
    }
}
