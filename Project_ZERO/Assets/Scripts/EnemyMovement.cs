using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement2 : MonoBehaviour
{
    float maxDist = 72f;
    float minDist = 65.5f;
    float speed = 5f;
    int direction = -1;

    // Use this for initialization
    void Start()
    {
        maxDist += transform.position.y;
        minDist -= transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case -1:
                // Moving Left
                if (transform.position.y >= minDist)
                {
                    direction = 1;
                }
                else
                {
                    this.transform.position += speed * -this.transform.up * Time.deltaTime;
                }
                break;

            case 1:
                //Moving Right
                if (transform.position.y < maxDist)
                {
                    this.transform.position += speed * this.transform.up * Time.deltaTime;
                }
                else
                {
                    direction = -1;
                }
                break;
        }
    }

}