using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public StatCharacter stat { get; protected set; }

    public Character(StatCharacter stat)
    {
        this.stat = stat;
    }
    
    ~Character()
    {
        Debug.Log("Character Destroy!!!");
    }
}
