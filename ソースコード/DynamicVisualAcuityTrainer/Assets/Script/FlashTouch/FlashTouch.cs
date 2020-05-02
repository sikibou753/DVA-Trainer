using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashTouch : MonoBehaviour
{
    public SceneChanger sceneChanger;
    public GameObject GeneFT;
    public CountDown countDown;
    public int maxNum;
    public static int MaxNum;
    public float displayLimit;
    public float maxInterval;
    float interval;
    float Timer;
    float MaxTime = 2.0f;
    public static int touchCount;
    int vanishCount;
    bool Started;
    bool Exist;
    bool Finish;

    GenerateFT generateFT;
    // Start is called before the first frame update
    void Start()
    {
        touchCount = 0;
        interval = maxInterval;
        Timer = MaxTime;
        MaxNum = maxNum;
        Started = false;
        Exist = false;
        Finish = false;
        vanishCount = 0;
        generateFT = GeneFT.GetComponent<GenerateFT>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!Started)
        {
            Started = countDown.GetIsStart();
        }

        if(vanishCount==maxNum)
        {
            Finish = true;

        }
        if (Finish)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                sceneChanger.ToResult();
            }
        }
        if (Started&&!Exist&&!Finish)
        {
            interval -= Time.deltaTime;
            if (interval <= 0)
            {
                generateFT.CanGenerate();
                Exist = true;
                interval = maxInterval;
            }
        }
    }

    public void AddTouchCount()
    {
        touchCount++;
    }
    public void Vanish()
    {
        Exist = false;
        vanishCount++;
    }
    public bool GetStart()
    {
        return Started;
    }

    public static int GetMaxFlashNum()
    {
        return MaxNum;
    }
    public static int GetTouchCount()
    {
        return touchCount;
    }
}
