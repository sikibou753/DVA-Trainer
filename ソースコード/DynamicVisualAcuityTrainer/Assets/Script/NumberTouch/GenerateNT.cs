using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateNT : MonoBehaviour
{
    public CountDown countDown;
   
    public int maxNum;
    public Vector2 startPos;
    public float sideLength;
    public int maxColNum;
    public int oneDigitFontSize;
    public int twoDigitsFontSize;
    public int threeDigitsFontSize;
    private int startNum;
    private int endNum;

    private List<int> numbers = new List<int>();

    private bool First;
    // Start is called before the first frame update
    void Start()
    {
        startNum = 1;
        endNum = maxNum;
        First = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obj = (GameObject)Resources.Load("Button");
        GameObject button;
        bool Started;
        Started = countDown.GetIsStart();
       

        if (Started && !First)
        {
            First = true;
            for (int i = startNum; i <= endNum; i++)
            {
                numbers.Add(i);
            }
            int colCount = 0;
            int rowCount = 0;
            int count = 0;
            while (numbers.Count > 0)
            {
                int index = Random.Range(0, numbers.Count);
                int rndNum = numbers[index];

                count++;
                rowCount = count % maxColNum;

                numbers.RemoveAt(index);
                button = Instantiate(obj, new Vector3(startPos.x + sideLength * rowCount, startPos.y - sideLength * colCount, 0.0f), Quaternion.identity);
                button.GetComponent<RectTransform>().sizeDelta = new Vector2(sideLength, sideLength);
                button.transform.SetParent(transform, false);

                //警告の出る書き方
                //button.transform.parent = transform; 

                button.GetComponentInChildren<Text>().text = rndNum.ToString();

                if (rndNum < 10)
                {
                    button.GetComponentInChildren<Text>().fontSize = oneDigitFontSize;
                }
                if (rndNum >= 10)
                {
                    button.GetComponentInChildren<Text>().fontSize = twoDigitsFontSize;
                }
                if (rndNum >= 100)
                {
                    button.GetComponentInChildren<Text>().fontSize = threeDigitsFontSize;
                }

                if (count % maxColNum == 0 && count >= maxColNum)
                {
                    colCount++;
                }

            }
        }
    }
}
