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

    public StatCharacter(string name, int hp = 100, int stamina = 40, int attack = 10, int defense = 15, int speed = 90)
    {
        this.name = name;
        this.hp = hp;
        this.stamina = stamina;
        this.attack = attack;
        this.defense = defense;
        this.speed = speed;
    }
}
