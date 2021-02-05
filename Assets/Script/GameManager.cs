using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    private static GameManager _instance = null;

    [SerializeField]
    private GameObject[] _inventoryObject;

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
        for (int i = 0; i < _inventoryObject.Length; i++)
        {
            _inventoryObject[i].GetComponent<SpriteRenderer>().sprite = Generator.Instance.CharacterList[i].Sprite;
            _inventoryObject[i].GetComponent<MouseOver>().currentType = ObjectType.CHARACTER;
            _inventoryObject[i].GetComponent<MouseOver>().currentCharacter = Generator.Instance.CharacterList[i];
        }
    }
    public void ChangeInventoryForEquipment()
    {
        for (int i = 0; i < _inventoryObject.Length; i++)
        {
            _inventoryObject[i].GetComponent<SpriteRenderer>().sprite = Generator.Instance.EquipmentList[i].Sprite;
            _inventoryObject[i].GetComponent<MouseOver>().currentType = ObjectType.EQUIPMENT;
            _inventoryObject[i].GetComponent<MouseOver>().currentEquipment = Generator.Instance.EquipmentList[i];
        }
    }

    public void QuitApplication()
    {
        Application.Quit();
        //Debug.Log("Exit!!");
    }
}
