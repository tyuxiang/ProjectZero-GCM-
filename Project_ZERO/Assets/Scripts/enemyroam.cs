using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyroam : MonoBehaviour
{
    int direction = -1;

    [SerializeField]
    private float maxDist = 2f;

    [SerializeField]
    private float minDist = 1.5f;

    [SerializeField]
    private float speed = 4f;

    private bool flipState;

    // Use this for initialization
    void Start()
    {
      
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