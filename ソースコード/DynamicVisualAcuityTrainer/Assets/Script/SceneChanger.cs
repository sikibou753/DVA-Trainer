using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static string oldSceneName;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            EndGame();
        }

    }

    //Game Main Loop
    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void ToMenu()
    {
        SceneManager.LoadScene("Menu");        
    }
    public void ToNT()
    {
        SceneManager.LoadScene("DifficultyNT");
    }
    public void ToFT()
    {
        SceneManager.LoadScene("DifficultyFT");
    }
    public void ToMP()
    {
        SceneManager.LoadScene("DifficultyMP");
    }
    public void ToResult()
    {
        oldSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Result");
    }
    public void ToRestart()
    {
        SceneManager.LoadScene(oldSceneName);
    }
    public void EndGame()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#elif UNITY_WEBGL
        Screen.fullScreen = false;

#elif UNITY_STANDALONE

        UnityEngine.Application.Quit();

#endif
    }

    //Number Touch
    public void ToNT5x5()
    {
        SceneManager.LoadScene("NT5x5");
    }
    public void ToNT7x7()
    {
        SceneManager.LoadScene("NT7x7");
    }
    public void ToNT10x10()
    {
        SceneManager.LoadScene("NT10x10");
    }

    //FlashTouch
    public void ToFTEZ()
    {
        SceneManager.LoadScene("FTEZ");
    }
    public void ToFTN()
    {
        SceneManager.LoadScene("FTN");
    }
    public void ToFTH()
    {
        SceneManager.LoadScene("FTH");
    }
    public void ToFTEX()
    {
        SceneManager.LoadScene("FTEX");
    }

    //MovePoint
    public void ToMPx1()
    {
        SceneManager.LoadScene("MPx1");
    }
    public void ToMPx2()
    {
        SceneManager.LoadScene("MPx2");
    }
    public void ToMPx4()
    {
        SceneManager.LoadScene("MPx4");
    }

    //一つ前のシーン名
    public static string ReturnOldSceneName()
    {
        return oldSceneName;
    }
}
