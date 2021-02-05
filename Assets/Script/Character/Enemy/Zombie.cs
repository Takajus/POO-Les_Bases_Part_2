using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Enemy
{
    public Zombie(StatCharacter stat) : base(stat)
    {
        sprite = Resources.Load<Sprite>("Pictures/Zombie");
    }
    public override void SaySomthing()
    {
        base.SaySomthing();
        Debug.Log("Grrrrrrr");
    }
}
