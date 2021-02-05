﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public Sprite sprite { get; protected set; }
    public StatCharacter stat { get; protected set; }

    public Character(StatCharacter stat)
    {
        this.stat = stat;
        sprite = null;
    }
    public virtual void SaySomthing()
    {

    }
}
