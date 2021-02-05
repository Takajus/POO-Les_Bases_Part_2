using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    //Private
    private static Generator _instance = null;

    public List<Character> CharacterList { get; private set; } = new List<Character>();
    public List<Equipment> EquipmentList { get; private set; } = new List<Equipment>();


    private Generator()
    {
    }

    public static Generator Instance
    {
        get => _instance;
    }

    private void Awake()
    {
        _instance = this;
    }

    //--------------------------------------------//
    //--------------Part Character----------------//
    //--------------------------------------------//
    public void GenerateCharacter()
    {
        if (CharacterList.Count != 0)
        {
            ClearCharacterList();
        }

        Character character = null;

        for (int i = 0; i < 3; i++)
        {
            int randType = Random.Range(0, 2);
            int randClass = Random.Range(0, 3);

            if (randType == 0)
            {
                if (randClass == 0)
                {
                    character = new Paladin(new StatCharacter("Link"));
                }
                else if (randClass == 1)
                {
                    character = new Knight(new StatCharacter("Arthur"));
                }
                else if (randClass == 2)
                {
                    character = new Rogue(new StatCharacter("John"));
                }
            }
            else if (randType == 1)
            {
                if (randClass == 0)
                {
                    character = new Zombie(new StatCharacter("Joseph"));
                }
                else if (randClass == 1)
                {
                    character = new Skeleton(new StatCharacter("Sans"));
                }
                else if (randClass == 2)
                {
                    character = new Vampire(new StatCharacter("Alva"));
                }
            }
            
            CharacterList.Add(character);
        }

        GameManager.Instance.ChangeInventoryForCharacter();
    }

    public void ClearCharacterList()
    {
        for (int i = CharacterList.Count - 1; i >= 0; i--)
        {
            CharacterList.RemoveAt(i);
        }
    }

    public void LogCharacterStat()
    {        
        for (int i = CharacterList.Count - 1; i >= 0; i--)
        {
            Debug.Log(CharacterList[i]);
            Debug.Log("Name :" + CharacterList[i].Stat.name + ". Hp :" + CharacterList[i].Stat.hp + ". Stamina :" + CharacterList[i].Stat.stamina + ". Attack :" + CharacterList[i].Stat.attack + ". Defence :" + CharacterList[i].Stat.defense + ". Speed :" + CharacterList[i].Stat.speed);
        }
        //Debug.Log(characterList.Count);
    }

    //--------------------------------------------//
    //--------------Part Equipment----------------//
    //--------------------------------------------//
    public void GenerateEquipment()
    {
        if (EquipmentList.Count != 0)
        {
            ClearEquipmentList();
        }

        Equipment equipment = null;

        for (int i = 0; i < 3; i++)
        {
            int randType = Random.Range(0, 2);
            int randClass = Random.Range(0, 3);

            if (randType == 0)
            {
                if (randClass == 0)
                {
                    equipment = new Dagger(new StatEquipment("Poisonous Dagger"));
                }
                else if (randClass == 1)
                {
                    equipment = new Longsword(new StatEquipment("Escalibur"));
                }
                else if (randClass == 2)
                {
                    equipment = new Spear(new StatEquipment("Divin Spear"));
                }
            }
            else if (randType == 1)
            {
                if (randClass == 0)
                {
                    equipment = new Helmet(new StatEquipment("Spartan Helmet"));
                }
                else if (randClass == 1)
                {
                    equipment = new Plastron(new StatEquipment("Turtle Shell"));
                }
                else if (randClass == 2)
                {
                    equipment = new Shield(new StatEquipment("Wall of Insanity"));
                }
            }

            EquipmentList.Add(equipment);
        }

        GameManager.Instance.ChangeInventoryForEquipment();
    }

    private void ClearEquipmentList()
    {
        for (int i = EquipmentList.Count - 1; i >= 0; i--)
        {
            EquipmentList.RemoveAt(i);
        }
    }

    public void LogEquipmentStat()
    {
        for (int i = EquipmentList.Count - 1; i >= 0; i--)
        {
            Debug.Log(EquipmentList[i]);
            Debug.Log("Name :" + EquipmentList[i].Stat.name +". Market Value :" + EquipmentList[i].Stat.marketValue + ". Attack Power :" + EquipmentList[i].Stat.attackPower + ". Defence Power :" + EquipmentList[i].Stat.defensePower);
        }
        //Debug.Log(equipmentList.Count);
    }
}
