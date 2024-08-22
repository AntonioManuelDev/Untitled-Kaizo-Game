using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DeathCounter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().SetText(SceneLoader.deathCounter.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}