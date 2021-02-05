using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour
{
    [SerializeField]
    private GameObject OnClickTextPrefab;
    [SerializeField]
    private GameObject StatMenuPrefab;
    [SerializeField]
    private Canvas canvas;
    private GameObject currentStatMenu;
    private GameObject currentOnClickText;

    private bool IsMouseOver = false;

    public ObjectType currentType = ObjectType.NONE;
    public Character currentCharacter;
    public Equipment currentEquipment;

    private void OnMouseOver()
    {
        if (!IsMouseOver)
        {
            IsMouseOver = true;
            if (currentType == ObjectType.CHARACTER)
            {
                currentStatMenu = Instantiate(StatMenuPrefab, canvas.transform);
                currentStatMenu.transform.GetChild(0).GetComponent<Text>().text = (currentCharacter.stat.name + "\n"
                                                                                   + "HP : " + currentCharacter.stat.hp + "\n"
                                                                                   + "Stamina : " + currentCharacter.stat.stamina + "\n"
                                                                                   + "Attack : " + currentCharacter.stat.attack + "\n"
                                                                                   + "Defence : " + currentCharacter.stat.defense + "\n"
                                                                                   + "Speed : " + currentCharacter.stat.speed).ToString(); 
                //Generator.Instance.LogCharacterStat();
            }
            else if (currentType == ObjectType.EQUIPMENT)
            {
                currentStatMenu = Instantiate(StatMenuPrefab, canvas.transform);
                currentStatMenu.transform.GetChild(0).GetComponent<Text>().text = (currentEquipment.stat.name + "\n"
                                                                                   + currentEquipment.stat.marketValue + " Gold\n"
                                                                                   + "Att : " + currentEquipment.stat.attackPower + "\n"
                                                                                   + "Def : " + currentEquipment.stat.defensePower).ToString();
                //Generator.Instance.LogEquipmentStat();
            }
        }
    }

    private void OnMouseDown()
    {
        if (currentOnClickText != null)
        {
            Destroy(currentOnClickText);
        }

        if (currentType == ObjectType.CHARACTER)
        {
            currentOnClickText = Instantiate(OnClickTextPrefab, canvas.transform);
            currentOnClickText.transform.GetComponent<Text>().text = currentCharacter.GetDialogueLine();
        }
        else if (currentType == ObjectType.EQUIPMENT)
        {
            currentOnClickText = Instantiate(OnClickTextPrefab, canvas.transform);
            currentOnClickText.transform.GetComponent<Text>().text = currentEquipment.GetDescription();
        }

        Destroy(currentOnClickText, 2.0F);
    }


    private void OnMouseExit()
    {
        IsMouseOver = false;
        Destroy(currentStatMenu);
        Destroy(currentOnClickText);
        //Debug.Log("Mouse Exit");
    }

}
