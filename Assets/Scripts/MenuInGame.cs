using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuInGame : MonoBehaviour
{
    private bool paused = false;
    private GameObject pauseMenu;
    private GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = GameObject.FindWithTag("LevelMenu");
        pauseMenu.SetActive(false);
        cam = GameObject.Find("Main Camera");
        cam.GetComponent<Camera>().backgroundColor = new Color(0.04f * SceneLoader.currentScene, 0.5f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                paused = true;
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            } else
            {
                Time.timeScale = 1;
                paused = false;
                pauseMenu.SetActive(false);
            }
        }
    }

    public void runLevel(int i)
    {
        Time.timeScale = 1;
        SceneLoader.loadNewScene(i);
    }

    public void backButton()
    {
        Time.timeScale = 1;
        SceneLoader.backToMenu();
    }
}