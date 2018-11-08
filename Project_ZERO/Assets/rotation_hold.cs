using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation_hold : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey("space"))
        {
            transform.Rotate(0, 0, 90*Time.deltaTime);
        }*/
        /*if (Input.GetKey("space") & main.instance.j == false)
        {
            main.instance.i = true;
            /*if (((Time.time - main.instance.lastTapTime) < main.instance.tapSpeed) & Time.time > 2)
            {
                main.instance.i = false;
                print("double tap");
                main.instance.j = true;
            }
            main.instance.lastTapTime = Time.time;
        }*/
        if (main.instance.i & !main.instance.j)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
            main.instance.angle += 90 * Time.deltaTime;
            /*if (main.instance.angle_counter >= 90 - (90 * Time.deltaTime))
            {
                main.instance.angle += 90;
                main.instance.error = 90 - (transform.localEulerAngles.z % 90);
                if (main.instance.error > 90 * Time.deltaTime)
                {
                    main.instance.error = -(90 - main.instance.error);
                }
                transform.Rotate(0, 0, main.instance.error);
                main.instance.i = false;
                main.instance.angle_counter = 0;
            }*/
            /*if (main.instance.angle >= 270)
            {
                main.instance.angle = -90;
            }*/
        }
        if (main.instance.j & !main.instance.i)
        {
            //print("angle counter: " + main.instance.angle_counter);
            transform.Rotate(0, 0, -90 * Time.deltaTime);
            main.instance.angle -= 90 * Time.deltaTime;
            /*if (main.instance.angle_counter <= -90 + (90 * Time.deltaTime))
            {
                main.instance.angle -= 90;
                main.instance.error = 90 + (transform.localEulerAngles.z % 90);
                if (main.instance.error > 90 * Time.deltaTime)
                {
                    main.instance.error = -(90 - main.instance.error);
                }
                print("error: " + main.instance.error);
                transform.Rotate(0, 0, -main.instance.error);
                main.instance.j = false;
                main.instance.angle_counter = 0;
            }
            if (main.instance.angle <= -450)
            {
                main.instance.angle = -90;
            }*/
        }
    }
}
