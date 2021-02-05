using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paladin : Hero
{
    public Paladin(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Paladin");
    }
    public override void SaySomthing()
    {
        base.SaySomthing();
        Debug.Log("I will prey for you !");
    }
}
