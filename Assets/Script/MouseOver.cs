using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOver : MonoBehaviour
{
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
                Generator.Instance.LogCharacterStat();
            }
            else if (currentType == ObjectType.EQUIPMENT)
            {
                Generator.Instance.LogEquipmentStat();
            }
        }
    }


    private void OnMouseExit()
    {
        IsMouseOver = false;
        Debug.Log("Mouse Exit");
    }

}
