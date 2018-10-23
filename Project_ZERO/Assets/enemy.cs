using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float maxDist = 2.5f;
    float minDist = -2.5f;
    float speed = 2f;
    int direction = -1;
    private bool flipState;

    // Use this for initialization
    void Start()
    {
        maxDist += transform.position.x;
        minDist -= transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case -1:
                // Moving Left
                if (transform.position.x <= minDist)
                {
                    direction = 1;
                }
                else
                {
                    this.transform.position += speed * -this.transform.right * Time.deltaTime;
                    GetComponent<SpriteRenderer>().flipX = flipState;
                }
                break;

            case 1:
                //Moving Right
                if (transform.position.x < maxDist)
                {
                    this.transform.position += speed * this.transform.right * Time.deltaTime;
                    GetComponent<SpriteRenderer>().flipX = !flipState;
                }
                else
                {
                    direction = -1;
                }
                break;
        }
    }

}