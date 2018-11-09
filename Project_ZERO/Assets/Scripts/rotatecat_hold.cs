using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatecat_hold : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (main.instance.i)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
            /*if (main.instance.error != 0)
            {
                transform.Rotate(0, 0, main.instance.error);
                main.instance.error = 0;
            }*/
        }
        if (main.instance.j)
        {
            transform.Rotate(0, 0, -90 * Time.deltaTime);
            /*if (main.instance.error != 0)
            {
                transform.Rotate(0, 0, main.instance.error);
                main.instance.error = 0;
            }*/
        }
    }
}
