using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DropDowmObj : MonoBehaviour
{
    public DropDownData dropDownData;
    int OptionDataCount;
    public List<Dropdown.OptionData> optionDatas;
    private void Start()
    {
        gameObject.GetComponent<Dropdown>().options.Clear();
        AddOption();
    }
    public void AddOption()
    {
        gameObject.GetComponent<Dropdown>().options.AddRange(dropDownData.data.optionData.options);

    }

}
