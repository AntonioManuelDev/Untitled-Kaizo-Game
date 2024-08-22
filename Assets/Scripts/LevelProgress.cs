using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelProgress : MonoBehaviour
{
    public Button[] lvlButtons;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 1 > PlayerPrefs.GetInt("unlockedLvl"))
            {
                lvlButtons[i].interactable = false;
            }
        }
    }
}