using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonNT : MonoBehaviour
{
    GameObject numbersObj;
    NumberTouch numberTouch;
    int thisNum;
    // Start is called before the first frame update
    void Start()
    {
        numbersObj = GameObject.Find("Numbers");
        numberTouch = numbersObj.GetComponent<NumberTouch>();
        thisNum = int.Parse(this.GetComponentInChildren<Text>().text);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void ClickButton()
    {
        if (thisNum == numberTouch.GetNowNum())
        {
            numberTouch.NumCountUp();
            this.GetComponentInChildren<Image>().color = Color.red;
            
        }
    }
}
