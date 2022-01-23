using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelChanger : MonoBehaviour
{
    GameObject picher;
    float ballSpeed = 53f;
    Vector3 projectionAngle = new Vector3(315f, 90f, 0);

    // Start is called before the first frame update
    void Start()
    {
        picher = GameObject.Find("Picher");
    }

    public void easyLevel()
    {
        picher.GetComponent<Picher>().deltaTime = 0f;

        float ballSpeed = 53f;
        projectionAngle.x = 315;

        picher.GetComponent<Picher>().projectionPower = ballSpeed;
        picher.transform.GetChild(0).GetComponent<Transform>().localEulerAngles = projectionAngle;

        transform.GetChild(0).GetComponent<Image>().color = Color.green;
        transform.GetChild(1).GetComponent<Image>().color = Color.white;
        transform.GetChild(2).GetComponent<Image>().color = Color.white;
        transform.GetChild(2).GetChild(0).GetComponent<Text>().color = Color.black;

        Debug.Log(projectionAngle);
    }

    public void normalLevel()
    {
        picher.GetComponent<Picher>().deltaTime = 0f;

        float ballSpeed = 100f;
        projectionAngle.x = 354;

        picher.GetComponent<Picher>().projectionPower = ballSpeed;
        picher.transform.GetChild(0).GetComponent<Transform>().localEulerAngles = projectionAngle;

        transform.GetChild(0).GetComponent<Image>().color = Color.white;
        transform.GetChild(1).GetComponent<Image>().color = Color.yellow;
        transform.GetChild(2).GetComponent<Image>().color = Color.white;
        transform.GetChild(2).GetChild(0).GetComponent<Text>().color = Color.black;

        Debug.Log(projectionAngle);
    }

    public void hardLevel()
    {
        picher.GetComponent<Picher>().deltaTime = 0f;

        float ballSpeed = 140f;
        projectionAngle.x = 358;

        picher.GetComponent<Picher>().projectionPower = ballSpeed;
        picher.transform.GetChild(0).GetComponent<Transform>().localEulerAngles = projectionAngle;

        transform.GetChild(0).GetComponent<Image>().color = Color.white;
        transform.GetChild(1).GetComponent<Image>().color = Color.white;
        transform.GetChild(2).GetComponent<Image>().color = Color.red;
        transform.GetChild(2).GetChild(0).GetComponent<Text>().color = Color.white;

        Debug.Log(projectionAngle);
    }
}
