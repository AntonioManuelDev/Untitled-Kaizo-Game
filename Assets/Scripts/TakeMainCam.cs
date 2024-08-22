using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeMainCam : MonoBehaviour
{

    GameObject mCam;
    // Start is called before the first frame update
    void Start()
    {
        mCam = GameObject.Find("Main Camera");
        GetComponent<Canvas>().worldCamera = mCam.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}