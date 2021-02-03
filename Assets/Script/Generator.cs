using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    //Private
    static private Generator _instance = null;

    private List<Character> charaterList = new List<Character>();
    private List<Equipment> equipmentList = new List<Equipment>();


    private Generator()
    {
    }

    public static Generator GetInstance()
    {
        if(_instance == null)
        {
            _instance = new Generator();
        }
        return _instance;
    }


    //--------------------------------------------//
    //--------------Part Character----------------//
    //--------------------------------------------//
    public void GenerateCharacter()
    {
        if (charaterList.Count != 0)
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
                    character = new Paladin(new StatCharacter("Link", 1000, 500, 9, 50, 600));
                }
                else if (randClass == 1)
                {
                    character = new Knight(new StatCharacter("Arthur", 100, 700, 100, 30, 630));
                }
                else if (randClass == 2)
                {
                    character = new Rogue(new StatCharacter("John", 30, 1000, 40, 5, 1000));
                }
            }
            else if (randType == 1)
            {
                if (randClass == 0)
                {
                    character = new Zombie(new StatCharacter("Joseph", 50, -1, 20, 10, 200));
                }
                else if (randClass == 1)
                {
                    character = new Skeleton(new StatCharacter("Sans", 25, -1, 30, 1, 300));
                }
                else if (randClass == 2)
                {
                    character = new Vampire(new StatCharacter("Alva", 500, 550, 70, 60, 400));
                }
            }
            
            charaterList.Add(character);
        }
        LogCharacterStat();
    }

    public void ClearCharacterList()
    {
        for (int i = charaterList.Count - 1; i >= 0; i--)
        {
            charaterList.RemoveAt(i);
        }
    }

    private void LogCharacterStat()
    {        
        for (int i = charaterList.Count - 1; i >= 0; i--)
        {
            Debug.Log(charaterList[i]);
        }
        Debug.Log(charaterList.Count);
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
                    equipment = new Dagger(new StatEquipment("Poisonous Dagger", 200, 200, 10));
                }
                else if (randClass == 1)
                {
                    equipment = new Longsword(new StatEquipment("Escalibur", 500, 400, 60));
                }
                else if (randClass == 2)
                {
                    equipment = new Spear(new StatEquipment("Divin Spear", 400, 300, 50));
                }
            }
            else if (randType == 1)
            {
                if (randClass == 0)
                {
                    equipment = new Helmet(new StatEquipment("Spartan Helmet", 600, 0, 100));
                }
                else if (randClass == 1)
                {
                    equipment = new Plastron(new StatEquipment("Turtle Shell", 800, 0, 200));
                }
                else if (randClass == 2)
                {
                    equipment = new Shield(new StatEquipment("Wall of Insanity", 1000, 50, 150));
                }
            }

            equipmentList.Add(equipment);
        }
        LogEquipmentStat();
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
        }
        Debug.Log(equipmentList.Count);
    }

}
