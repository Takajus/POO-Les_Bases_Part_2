using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    public Zombie(StatCharacter stat) : base(stat)
    {
        Sprite = Resources.Load<Sprite>("Pictures/Zombie");
    }
    public override string GetDialogueLine()
    {
        base.GetDialogueLine();
        return "Grrrrrrr";
    }
}
