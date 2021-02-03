using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    void Start()
    {
        /*new Rogue(new StatCharacter("Michel"));
        Debug.Log(Character.charaterList[0].stat.name);
        Debug.Log(Character.charaterList[0].stat.hp);
        Debug.Log(Character.charaterList[0].stat.stamina);
        Debug.Log(Character.charaterList[0].stat.attack);
        Debug.Log(Character.charaterList[0].stat.defense);
        Debug.Log(Character.charaterList[0].stat.speed);*/

    }

    void Update()
    {
        
    }

    public void GenerateCharacter()
    {
        if(Character.charaterList.Count != 0)
        {
            ClearCharacterList();
            Debug.Log("Charactors Clear!!!");
        }

        for (int i = 0; i < 3; i++)
        {
            int randType = Random.Range(0, 2);
            int randClass = Random.Range(0, 3);

            if (randType == 0)
            {
                if (randClass == 0)
                {
                    new Paladin(new StatCharacter("Link", 1000, 500, 9, 50, 600));
                }
                else if (randClass == 1)
                {
                    new Knight(new StatCharacter("Arthur", 100, 700, 100, 30, 630));
                }
                else if (randClass == 2)
                {
                    new Rogue(new StatCharacter("John", 30, 1000, 40, 5, 1000));
                }
            }
            else if (randType == 1)
            {
                if (randClass == 0)
                {
                    new Zombie(new StatCharacter("Joseph", 50, -1, 20, 10, 200));
                }
                else if (randClass == 1)
                {
                    new Skeleton(new StatCharacter("Sans", 25, -1, 30, 1, 300));
                }
                else if (randClass == 2)
                {
                    new Vampire(new StatCharacter("Alva", 500, 550, 70, 60, 400));
                }
            }
        }
        LogCharacterStat();
    }

    public void ClearCharacterList()
    {
        for (int i = Character.charaterList.Count - 1; i >= 0; i--)
        {
            Character.charaterList[i].Destroy();
        }
        LogCharacterStat();
    }

    private void LogCharacterStat()
    {
        for (int i = Character.charaterList.Count - 1; i >= 0; i--)
        {
            Debug.Log(Character.charaterList[i]);
        }
        Debug.Log(Character.charaterList.Count);
    }
}
