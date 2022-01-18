using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetChestTransposition : MonoBehaviour
{
    Vector3 headPos;
    //Quaternion headRot;

    [SerializeField]
    public float deltaTall = 0.15f; //or0.4f
    [SerializeField]
    public GameObject headTarget;

    // Start is called before the first frame update
    void Start()
    {
        headTarget = GameObject.Find("HeadTarget");
    }

    // Update is called once per frame
    void Update()
    {
        headPos = headTarget.GetComponent<Transform>().position;
        headPos.y -= deltaTall;
        transform.position = headPos;
    }
}
