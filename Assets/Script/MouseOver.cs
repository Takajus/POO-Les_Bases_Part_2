using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour
{
    [SerializeField]
    private GameObject _onClickTextPrefab;
    [SerializeField]
    private GameObject _statMenuPrefab;
    [SerializeField]
    private Canvas _canvas;
    private GameObject _currentStatMenu;
    private GameObject _currentOnClickText;

    private bool _isMouseOver = false;

    public ObjectType currentType = ObjectType.NONE;
    public Character currentCharacter;
    public Equipment currentEquipment;

    private void OnMouseOver()
    {
        if (!_isMouseOver)
        {
            _isMouseOver = true;
            if (currentType == ObjectType.CHARACTER)
            {
                _currentStatMenu = Instantiate(_statMenuPrefab, _canvas.transform);
                _currentStatMenu.transform.GetChild(0).GetComponent<Text>().text = (currentCharacter.Stat.name + "\n"
                                                                                   + "HP : " + currentCharacter.Stat.hp + "\n"
                                                                                   + "Stamina : " + currentCharacter.Stat.stamina + "\n"
                                                                                   + "Attack : " + currentCharacter.Stat.attack + "\n"
                                                                                   + "Defence : " + currentCharacter.Stat.defense + "\n"
                                                                                   + "Speed : " + currentCharacter.Stat.speed).ToString(); 
                //Generator.Instance.LogCharacterStat();
            }
            else if (currentType == ObjectType.EQUIPMENT)
            {
                _currentStatMenu = Instantiate(_statMenuPrefab, _canvas.transform);
                _currentStatMenu.transform.GetChild(0).GetComponent<Text>().text = (currentEquipment.Stat.name + "\n"
                                                                                   + currentEquipment.Stat.marketValue + " Gold\n"
                                                                                   + "Att : " + currentEquipment.Stat.attackPower + "\n"
                                                                                   + "Def : " + currentEquipment.Stat.defensePower).ToString();
                //Generator.Instance.LogEquipmentStat();
            }
        }
    }

    private void OnMouseDown()
    {
        if (_currentOnClickText != null)
        {
            Destroy(_currentOnClickText);
        }

        if (currentType == ObjectType.CHARACTER)
        {
            _currentOnClickText = Instantiate(_onClickTextPrefab, _canvas.transform);
            _currentOnClickText.transform.GetComponent<Text>().text = currentCharacter.GetDialogueLine();
        }
        else if (currentType == ObjectType.EQUIPMENT)
        {
            _currentOnClickText = Instantiate(_onClickTextPrefab, _canvas.transform);
            _currentOnClickText.transform.GetComponent<Text>().text = currentEquipment.GetDescription();
        }

        Destroy(_currentOnClickText, 2.0F);
    }


    private void OnMouseExit()
    {
        _isMouseOver = false;
        Destroy(_currentStatMenu);
        Destroy(_currentOnClickText);
        //Debug.Log("Mouse Exit");
    }

}
