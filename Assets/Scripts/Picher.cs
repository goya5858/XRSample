using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picher : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballSpawnOffset;

    [SerializeField]
    public float span = 3.0f;
    public float deltaTime = 0;

    [SerializeField]
    public float projectionPower = 800f;
    float destroyTime = 3.0f;
    // Start is called before the first frame update

    [SerializeField]
    public bool isThrow = false;

    //void Start()
    //{}

    // Update is called once per frame
    void Update()
    {   
        if (isThrow)
        {
            this.deltaTime += Time.deltaTime;
            if (this.deltaTime > this.span)
            {
                this.deltaTime = 0;
                GameObject cloneBall = Instantiate(ballPrefab, ballSpawnOffset.position, ballSpawnOffset.rotation);
                Rigidbody ballRigidbody = cloneBall.GetComponent<Rigidbody>();
                if (ballRigidbody != null)
                {
                    ballRigidbody.AddForce(cloneBall.transform.forward * projectionPower);
                }
                Destroy(cloneBall, destroyTime);
            }
        }
    }
}
