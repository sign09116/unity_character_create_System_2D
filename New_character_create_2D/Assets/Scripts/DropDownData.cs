using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DT;
using System;
[System.Serializable]
public class PartsData
{
    public Dropdown.OptionDataList optionData;

}

[CreateAssetMenu(fileName = "PartsOptionData", menuName = "DT/Creat Data Asset")]
public class DropDownData : ScriptableObject
{
    public PartsData data;

}
