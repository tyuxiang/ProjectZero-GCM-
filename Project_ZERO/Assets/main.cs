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
    public float tapSpeed = 0.5f; //in seconds
    public float lastTapTime = 0;
    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
