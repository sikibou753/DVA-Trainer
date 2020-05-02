using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberTouch : MonoBehaviour
{
    public int maxNum;
    float Timer;
    float MaxTime = 2.0f;
    int startNum;
    int nowNum;
    bool[] First=new bool[2];
    public SceneChanger sceneChanger;
    public GameObject NextNumText;
    public CountDown countDown;
    public MyTimer myTimer;

    // Start is called before the first frame update
    void Start()
    {
        startNum = 1;
        nowNum = startNum ;
        Timer = MaxTime;
        First[0] = false;
        First[1] = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (countDown.GetIsStart())
        {
            //一度だけ作動
            if (!First[0])
            {
                myTimer.StartTimer();
                First[0] = true;
            }

            NextNumText.GetComponent<Text>().text = "Next " + nowNum;
        }

        if (nowNum > maxNum)
        {
            //一度だけ作動
            if (!First[1])
            {
                myTimer.StopTimer();
            }
            First[1] = true;

            NextNumText.GetComponent<Text>().text = "Finish";
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                sceneChanger.ToResult();
            } 
        }
        
    }

    public int GetNowNum()
    {
        return nowNum;
    }

    public void NumCountUp()
    {
        nowNum++;
    }

}
