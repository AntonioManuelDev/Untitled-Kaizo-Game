using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    static public int deathCounter;
    private void Start()
    {
        GameObject m = GameObject.Find("music(Clone)");
        if (m == null)
        {
            m = Resources.Load<GameObject>("music");
            Instantiate(m, Vector3.zero, Quaternion.identity);
        }
    }
    static public int currentScene;
    static public void reloadScene()
    {
        SceneManager.LoadScene(currentScene);
    }
    static public void loadNewScene(int newScene)
    {
        currentScene = newScene;
        if(currentScene >= PlayerPrefs.GetInt("unlockedLvl"))
        {
            PlayerPrefs.SetInt("unlockedLvl", currentScene);
        }
        SceneManager.LoadScene(currentScene);
    }
    public void QuitGame()
    {
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }
    public void resetProgress()
    {
        PlayerPrefs.SetInt("unlockedLvl",1);
    }
    public void unlockAll()
    {
        PlayerPrefs.SetInt("unlockedLvl", 16);
    }
    static public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
