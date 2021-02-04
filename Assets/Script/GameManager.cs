using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;

    [SerializeField]
    private GameObject[] inventoryObject;

    private GameManager()
    {

    }

    public static GameManager Instance
    {
        get => _instance;
    }

    private void Awake()
    {
        _instance = this;
    }

    public void ChangeInventoryForCharacter()
    {
        for (int i = 0; i < inventoryObject.Length; i++)
        {
            inventoryObject[i].GetComponent<SpriteRenderer>().sprite = Generator.Instance.characterList[i].sprite;
            inventoryObject[i].GetComponent<MouseOver>().currentType = ObjectType.CHARACTER;
            inventoryObject[i].GetComponent<MouseOver>().currentCharacter = Generator.Instance.characterList[i];
        }
    }
    public void ChangeInventoryForEquipment()
    {
        for (int i = 0; i < inventoryObject.Length; i++)
        {
            inventoryObject[i].GetComponent<SpriteRenderer>().sprite = Generator.Instance.equipmentList[i].sprite;
            inventoryObject[i].GetComponent<MouseOver>().currentType = ObjectType.EQUIPMENT;
            inventoryObject[i].GetComponent<MouseOver>().currentEquipment = Generator.Instance.equipmentList[i];
        }
    }
}
