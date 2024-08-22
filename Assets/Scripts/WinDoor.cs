using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDoor : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneLoader.loadNewScene(SceneLoader.currentScene+1);
        }
    }
}
