using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picher : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballSpawnOffset;
    float span = 3.0f;
    float deltaTime = 0;

    float projectionPower = 400f;
    float destroyTime = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
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
