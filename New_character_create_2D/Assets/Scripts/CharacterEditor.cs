using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
namespace DT
{
    public class CharacterEditor : MonoBehaviour
    {

        #region 屬性
        public Dropdown[] Parts;
        public GameObject[] PartsAssetSprite;
        string[] m_partsMenu;
        public List<string> partsMenu;
        public GameObject[] LabelName;




        #endregion
        private void Awake()
        {
            Parts = FindObjectsOfType<Dropdown>();
            partsMenu.Add("Head");
            partsMenu.Add("Helmet");
            partsMenu.Add("Body");
            partsMenu.Add("Hand");
            partsMenu.Add("Leg");
            LabelName = GameObject.FindGameObjectsWithTag("LabelName");

        }
        private void Start()
        {

            RefreshLabelName();

        }
        public void RefreshLabelName()
        {
            for (int i = 0; i < Parts.Length; i++)
            {
                LabelName[i].GetComponent<Text>().text = partsMenu[i];
            }

        }
        public void RefreshLabelSprite()
        {
            for (int i = 0; i < Parts.Length; i++)
            {

            }
        }


    }
}








