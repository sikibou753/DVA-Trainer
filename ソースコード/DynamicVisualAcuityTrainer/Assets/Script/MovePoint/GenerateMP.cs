using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMP : MonoBehaviour
{
    public CountDown countDown;
    public Vector2 startPos;
    GameObject obj;
    bool First;
    // Start is called before the first frame update
    void Start()
    {
         obj = (GameObject)Resources.Load("Point");
        First = false;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject MP;
        bool Started;
        Started = countDown.GetIsStart();

        if (Started && !First)
        {
            First = true;
            MP = Instantiate(obj, new Vector3(startPos.x, startPos.y, 0.0f), Quaternion.identity);
            MP.transform.SetParent(transform, false);
        }
    }

    public Vector2 GetStartPos()
    {
        return startPos;
    }
}
