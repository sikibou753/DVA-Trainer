using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTimer : MonoBehaviour
{
    float elapsedTime;
    public static int resultTime;
    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = -1;
    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime >= 0)
        {
            elapsedTime += Time.deltaTime;
        }
        
    }

    public void StartTimer()
    {
        elapsedTime = 0;
    }

    public void StopTimer()
    {
        resultTime = (int)elapsedTime;
    }

    public static int ReturnResultTime()
    {
        return resultTime;
        
    }
}
