using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    int resultTime;
    int resultPiecesFT;
    int MaxNumFT;
    string oldSceneName;
    // Start is called before the first frame update
    void Start()
    {
        resultTime = MyTimer.ReturnResultTime();
        oldSceneName = SceneChanger.ReturnOldSceneName();
        resultPiecesFT = FlashTouch.GetTouchCount();
        MaxNumFT = FlashTouch.GetMaxFlashNum();
    }

    // Update is called once per frame
    void Update()
    {
        if (oldSceneName == "NT5x5" || oldSceneName == "NT7x7" || oldSceneName == "NT10x10")
        {
            this.GetComponent<Text>().text = resultTime.ToString() + " sec";
        }
        else if (oldSceneName == "FTEZ" || oldSceneName == "FTN" || oldSceneName == "FTH" || oldSceneName == "FTEX")
        {
            this.GetComponent<Text>().text = resultPiecesFT.ToString() + " / " + MaxNumFT.ToString();
        }
        else
        {
            this.GetComponent<Text>().text = "";
        }
    }
}
