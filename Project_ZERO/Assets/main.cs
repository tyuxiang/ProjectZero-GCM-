using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public static main instance;
    public bool i=false;
    public bool j = false;
    public float angle_counter = 0;
    public float angle = -90;
    public float error = 0; 
    public double tapSpeed = 0.1f; //in seconds
    public float lastTapTime = 0;
    public float duration;
    public GameObject lightningone;
    public Transform lightningposition;
    public float respawntimer;
    public float respawntimer2;
    public GameObject lightningtwo;
    public Transform lightningtwoposition;
    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (angle >= 270)
        {
            angle -= 360;
        }
        if (Input.GetKey("space") & j == false & Time.time >= 0.5f)
        {
            duration += Time.deltaTime;
            if (Time.time - lastTapTime <= 10 * Time.deltaTime)
            {
                j = true;
            }
            else
            {
                if(duration >= 10 * Time.deltaTime)
                {
                    i = true;
                }
            }
        }
        if (Input.GetKeyUp("space"))
        {
            duration = 0;
            i = false;
            j = false;
            lastTapTime = Time.time;
        }

        if (respawntimer2<6){
            respawntimer2 += 1 * Time.deltaTime;
        }
        if(respawntimer2>6){
            Instantiate(lightningtwo, lightningtwoposition.position, lightningtwoposition.rotation);
            respawntimer2 = 0;
        }
        if(respawntimer<6){
           respawntimer += 1 * Time.deltaTime;
        }

        if(respawntimer>6)
        {
            Instantiate(lightningone, lightningposition.position, lightningposition.rotation);
            respawntimer = 0;
     
        }
    }
}
