using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    // Start is called before the first frame update
    float MaxTime = 4;
    float Timer;
    public bool IsStrart;

    void Start()
    {
        IsStrart = false;
        Timer = MaxTime;
        GetComponent<Text>().text = ((int)Timer).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer >= 0)
        {
            Timer -= Time.deltaTime;
            if (Timer >= 1)
            {
                GetComponent<Text>().text = ((int)Timer).ToString();
            }
            if (Timer <= 0)
            {
                GetComponent<Text>().text = "";
                IsStrart = true;
                
            }
        }
    }

    public bool GetIsStart()
    {
        return IsStrart;
    }
}
