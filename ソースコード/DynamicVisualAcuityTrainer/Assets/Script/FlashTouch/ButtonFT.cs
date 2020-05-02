using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonFT : MonoBehaviour
{
    GameObject ft;
    float Timer;
    float MaxTime;

    FlashTouch flashTouch;
    // Start is called before the first frame update
    void Start()
    {
        ft = GameObject.Find("GenerateButton");
        flashTouch = ft.GetComponent<FlashTouch>();
        MaxTime = ft.GetComponent<FlashTouch>().displayLimit;
        Timer = MaxTime;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            flashTouch.Vanish();
            Destroy(this.gameObject);
        }
    }

    public void OnClick()
    {
        flashTouch.AddTouchCount();
        flashTouch.Vanish();
        Destroy(this.gameObject);
    }
}
