using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct StatCharacter
{
    public string name;
    public int hp;
    public int stamina;
    public int attack;
    public int defense;
    public int speed;

    public StatCharacter(string name)
    {
        this.name = name;
        this.hp = Random.Range(50, 151);
        this.stamina = Random.Range(80, 121);
        this.attack = Random.Range(20, 61);
        this.defense = Random.Range(10, 21);
        this.speed = Random.Range(10, 31);
    }
}
