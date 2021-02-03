using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    static public List<Character> charaterList = new List<Character>();
    public StatCharacter stat { get; protected set; }

    public Character(StatCharacter stat)
    {
        this.stat = stat;
        charaterList.Add(this);
    }
    
    ~Character()
    {
        Debug.Log("Character Destroy!!!");
    }

    public void Destroy()
    {
        charaterList.RemoveAt(charaterList.IndexOf(this));
    }
}
