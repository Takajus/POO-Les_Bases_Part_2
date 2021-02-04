using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    //Private
    private static Generator _instance = null;

    public List<Character> characterList { get; private set; } = new List<Character>();
    public List<Equipment> equipmentList { get; private set; } = new List<Equipment>();


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
        if (characterList.Count != 0)
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
            
            characterList.Add(character);
        }
        LogCharacterStat();
        GameManager.Instance.ChangeInventoryForCharacter();
    }

    public void ClearCharacterList()
    {
        for (int i = characterList.Count - 1; i >= 0; i--)
        {
            characterList.RemoveAt(i);
        }
    }

    private void LogCharacterStat()
    {        
        for (int i = characterList.Count - 1; i >= 0; i--)
        {
            Debug.Log(characterList[i]);
            Debug.Log("Name :" + characterList[i].stat.name);
            Debug.Log("Hp :" + characterList[i].stat.hp);
            Debug.Log("Stamina :" + characterList[i].stat.stamina);
            Debug.Log("Attack :" + characterList[i].stat.attack);
            Debug.Log("Defence :" + characterList[i].stat.defense);
            Debug.Log("Speed :" + characterList[i].stat.speed);
        }
        Debug.Log(characterList.Count);
    }

    //--------------------------------------------//
    //--------------Part Equipment----------------//
    //--------------------------------------------//
    public void GenerateEquipment()
    {
        if (equipmentList.Count != 0)
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

            equipmentList.Add(equipment);
        }
        LogEquipmentStat();
        GameManager.Instance.ChangeInventoryForEquipment();
    }

    private void ClearEquipmentList()
    {
        for (int i = equipmentList.Count - 1; i >= 0; i--)
        {
            equipmentList.RemoveAt(i);
        }
    }

    private void LogEquipmentStat()
    {
        for (int i = equipmentList.Count - 1; i >= 0; i--)
        {
            Debug.Log(equipmentList[i]);
            Debug.Log("Name :" + equipmentList[i].stat.name);
            Debug.Log("Market Value :" + equipmentList[i].stat.marketValue);
            Debug.Log("Attack Power :" + equipmentList[i].stat.attackPower);
            Debug.Log("Defence Power :" + equipmentList[i].stat.defensePower);

        }
        Debug.Log(equipmentList.Count);
    }

}
