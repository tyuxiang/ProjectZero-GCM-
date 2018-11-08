using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
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
                if (transform.position.y <= minDist)
                {
                    direction = 1;
                }
                else
                {
                    this.transform.position += speed * -this.transform.up * Time.deltaTime;
                    GetComponent<SpriteRenderer>().flipY = flipState;
                }
                break;

            case 1:
                //Moving Right
                if (transform.position.y < maxDist)
                {
                    this.transform.position += speed * this.transform.up * Time.deltaTime;
                    GetComponent<SpriteRenderer>().flipY = !flipState;
                }
                else
                {
                    direction = -1;
                }
                break;
        }
    }

}