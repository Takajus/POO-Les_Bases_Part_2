using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : Hero
{
    public Knight(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Knight");
    }
    public override void SaySomthing()
    {
        base.SaySomthing();
        Debug.Log("LEEROYYYYYYYYY JENKINS !!");
    }
}
