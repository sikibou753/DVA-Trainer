using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointMP : MonoBehaviour
{
    public GameObject mp;
    int multiplier;
    public float speed;
    Vector2 subSpeed;
    Rigidbody2D rb;

    List<Vector2> TurnPos = new List<Vector2>();
    List<string> TurnType = new List<string>();
    Vector2 nextPos;
    string nextType;
    float margin;
    int value;
    Vector2[] origin = new Vector2[2];
    Vector2 oldPos = new Vector2(0, 0);
    // Start is called before the first frame update
    void Start()
    {
        mp= GameObject.Find("GeneratePoint");
        multiplier = mp.GetComponent<MovePoint>().ReturnMultiplier();
        oldPos = mp.GetComponent<GenerateMP>().GetStartPos();
        speed = speed * multiplier;
        subSpeed.x = speed;
        subSpeed.y = 0;
        margin = 160;
        value = 0;
        rb = GetComponent<Rigidbody2D>();
        bool First = false;
        origin[0].x = -810;
        origin[1].x = 790;
        origin[0].y = 430;
        origin[1].y = -370;

        //横
        for (int i = 0; i < 11; i++)
        {
            if (i % 4 == 0)
            {
                if (!First)
                {
                    TurnPos.Add(new Vector2(origin[1].x, origin[0].y));
                    First = true;
                }
                else
                {
                    TurnPos.Add(new Vector2(origin[1].x, TurnPos[TurnPos.Count - 1].y));
                }
            }
            if (i % 4 == 1)
            {
                TurnPos.Add(new Vector2(origin[1].x, TurnPos[TurnPos.Count - 1].y - margin));
            }
            if (i % 4 == 2)
            {
                TurnPos.Add(new Vector2(origin[0].x, TurnPos[TurnPos.Count-1].y));
            }
            if (i % 4 == 3)
            {
                TurnPos.Add(new Vector2(origin[0].x, TurnPos[TurnPos.Count - 1].y - margin));
            }
        }

        //横折り返し
        for (int i = 0; i < 10; i++)
        {
            if (i % 4 == 0)
            {
                TurnPos.Add(new Vector2(origin[0].x, TurnPos[TurnPos.Count - 1].y + margin));
                
            }
            if (i % 4 == 1)
            {
                TurnPos.Add(new Vector2(origin[1].x, TurnPos[TurnPos.Count - 1].y));
            }
            if (i % 4 == 2)
            {
                TurnPos.Add(new Vector2(origin[1].x, TurnPos[TurnPos.Count - 1].y+margin));
            }
            if (i % 4 == 3)
            {
                TurnPos.Add(new Vector2(origin[0].x, TurnPos[TurnPos.Count - 1].y));
            }
        }

        //縦
        for (int i = 0; i < 21; i++)
        {
            if (i % 4 == 0)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x, origin[1].y));

            }
            if (i % 4 == 1)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x-margin, origin[1].y));
            }
            if (i % 4 == 2)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x, origin[0].y));
            }
            if (i % 4 == 3)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x-margin, origin[0].y));
            }
        }

        //縦折り返し
        for (int i = 0; i < 20; i++)
        {
            if (i % 4 == 0)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x + margin, origin[1].y));

            }
            if (i % 4 == 1)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x, origin[0].y));
            }
            if (i % 4 == 2)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x + margin, origin[0].y));
            }
            if (i % 4 == 3)
            {
                TurnPos.Add(new Vector2(TurnPos[TurnPos.Count - 1].x, origin[1].y));
            }
        }

        //横
        //TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        //横折り返し
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        //縦
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonL");
        TurnType.Add("HorizonD");
        //縦折り返し
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonU");
        TurnType.Add("HorizonR");
        TurnType.Add("HorizonD");
        TurnType.Add("TurnEnd");

        nextPos = TurnPos[0];
        nextType = TurnType[0];

        TurnPos.RemoveAt(0);
        TurnType.RemoveAt(0);

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(subSpeed.x, subSpeed.y);
        // Debug.Log(transform.localPosition);

        if (transform.localPosition.x > nextPos.x && value == 1)
        {
            Debug.Log("OK");
            transform.localPosition = nextPos;
            oldPos.x = transform.localPosition.x;
            oldPos.y = transform.localPosition.y;

            if (TurnPos.Count > 0)
            {
                nextPos = TurnPos[0];
                TurnPos.RemoveAt(0);
            }
        }
        else if (oldPos.x < nextPos.x && oldPos.y == nextPos.y)
        {
            subSpeed.x = speed;
            subSpeed.y = 0;
            value = 1;
        }
        if (transform.localPosition.y < nextPos.y && value == 2)
        {
            transform.localPosition = nextPos;
            oldPos.x = transform.localPosition.x;
            oldPos.y = transform.localPosition.y;

            if (TurnPos.Count > 0)
            {
                nextPos = TurnPos[0];
                TurnPos.RemoveAt(0);
            }
        }
        else if (oldPos.x == nextPos.x && oldPos.y > nextPos.y)
        {
            
            subSpeed.x = 0;
            subSpeed.y = -speed;
            value = 2;
        }
        if (transform.localPosition.x < nextPos.x && value == 3)
        {
            transform.localPosition = nextPos;
            oldPos.x = transform.localPosition.x;
            oldPos.y = transform.localPosition.y;

            if (TurnPos.Count > 0)
            {
                nextPos = TurnPos[0];
                TurnPos.RemoveAt(0);
            }
        }
        else if (oldPos.x > nextPos.x && oldPos.y == nextPos.y)
        {
            subSpeed.x = -speed;
            subSpeed.y = 0;
            value = 3;
        }
        if (transform.localPosition.y > nextPos.y && value == 4)
        {
            transform.localPosition = nextPos;
            oldPos.x = transform.localPosition.x;
            oldPos.y = transform.localPosition.y;

            if (TurnPos.Count > 0)
            {
                nextPos = TurnPos[0];
                TurnPos.RemoveAt(0);
            }
        }
        else if (oldPos.x == nextPos.x && oldPos.y < nextPos.y)
        {

            subSpeed.x = 0;
            subSpeed.y = speed;
            value = 4;
        }

        if (TurnPos.Count==0&& nextPos.y == transform.localPosition.y)
        {
            mp.GetComponent<MovePoint>().NowFinish();
            subSpeed.x = 0;
            subSpeed.y = 0;
        }
        
    }
}
