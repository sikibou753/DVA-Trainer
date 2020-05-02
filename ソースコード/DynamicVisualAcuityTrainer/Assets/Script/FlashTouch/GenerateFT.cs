using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateFT : MonoBehaviour
{
    public float diaLength;
    public GameObject FT;
    GameObject FTB;
    bool Generate;
    GameObject obj;

    FlashTouch flashTouch;
    // Start is called before the first frame update
    void Start()
    {
        obj = (GameObject)Resources.Load("FlashButton");
        Generate = false;
        flashTouch = FT.GetComponent<FlashTouch>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flashTouch.GetStart() && !Generate)
        {
            FTB = Instantiate(obj, new Vector3(Random.Range(-810, 810), Random.Range(-420, 420), 0.0f), Quaternion.identity);
            FTB.GetComponent<RectTransform>().sizeDelta = new Vector2(diaLength, diaLength);
            FTB.transform.SetParent(transform, false);

            Generate = true;
        }
    }

    public void CanGenerate()
    {
        Generate = false;
    }
}
