using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameStarter : MonoBehaviour
{

    public GameObject picher;
    GameObject buttonText;
    Color startButtonColor;

    public void Start()
    {
        picher = GameObject.Find("Picher");
        buttonText = transform.GetChild(0).gameObject;

        if (picher.GetComponent<Picher>().isThrow)
        {
            gameObject.GetComponent<Button>().GetComponent<Image>().color = Color.blue;
            //transform.GetChild(0).GetComponent<Text>().color = Color.white;
            buttonText.GetComponent<Text>().text = "Stop Game";
        }
        else
        {
            ColorUtility.TryParseHtmlString("#ffad00", out startButtonColor);
            gameObject.GetComponent<Button>().GetComponent<Image>().color = startButtonColor;
            //transform.GetChild(0).GetComponent<Text>().color = Color.black;
            buttonText.GetComponent<Text>().text = "Start Game";
        }
    }
    /// ボタンをクリックした時の処理
    public void OnClick()
    {
        //Debug.Log("Button click!");
        if (picher.GetComponent<Picher>().isThrow)
        {
            picher.GetComponent<Picher>().isThrow = false;
            buttonText.GetComponent<Text>().text = "Start Game";

            ColorUtility.TryParseHtmlString("#ffad00", out startButtonColor);
            gameObject.GetComponent<Button>().GetComponent<Image>().color = startButtonColor;
            //transform.GetChild(0).GetComponent<Text>().color = Color.black;
        }
        else
        {
            picher.GetComponent<Picher>().isThrow = true;
            picher.GetComponent<Picher>().deltaTime = 2.0f;
            buttonText.GetComponent<Text>().text = "Stop Game";

            gameObject.GetComponent<Button>().GetComponent<Image>().color = Color.blue;
            //transform.GetChild(0).GetComponent<Text>().color = Color.white;
        }
        
    }
}
