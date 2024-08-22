using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScreenLvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().SetText(SceneLoader.currentScene.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}