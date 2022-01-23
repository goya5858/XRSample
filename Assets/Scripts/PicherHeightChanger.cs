using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PicherHeightChanger : MonoBehaviour
{
    GameObject picher;
    float sliderValue = 0.5f;
    Vector3 picherPosition = new Vector3(-12.49f, 0.46f, 0);

    // Start is called before the first frame update
    void Start()
    {
        picher = GameObject.Find("Picher");
    }

    public void onChange()
    {
        //// Sliderの値の取得
        sliderValue = GetComponent<Slider>().value; // 0～１の値をとる
        picherPosition.y = 0.46f + (sliderValue - 0.5f);
        picher.transform.position = picherPosition;
    }
}
