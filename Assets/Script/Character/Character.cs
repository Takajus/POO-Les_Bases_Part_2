using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public Sprite Sprite { get; protected set; }
    public StatCharacter Stat { get; protected set; }

    public Character(StatCharacter stat)
    {
        this.Stat = stat;
        Sprite = null;
    }
    public virtual string GetDialogueLine()
    {
        return "nothing";
    }
}
