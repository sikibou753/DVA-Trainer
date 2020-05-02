using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePoint : MonoBehaviour
{
    public SceneChanger sceneChanger;
    public int multiplier;
    float Timer;
    float MaxTime = 2.0f;
    bool Finish;
    // Start is called before the first frame update
    void Start()
    {
        Finish = false;
        Timer = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Finish)
        {
            Timer -= Time.deltaTime;
            if (Timer <= 0)
            {
                sceneChanger.ToResult();
            }
        }
    }

    public void NowFinish()
    {
        Finish = true;
    }

    public int ReturnMultiplier()
    {
        return multiplier;
    }
}
