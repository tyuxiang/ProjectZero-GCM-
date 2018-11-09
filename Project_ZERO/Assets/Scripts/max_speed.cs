using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class max_speed : MonoBehaviour {
    public Rigidbody2D rb;
    public static float maxSpeed = 10f;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
