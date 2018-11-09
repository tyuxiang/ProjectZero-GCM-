﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour {
	float vert = 0;
    float horz = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(main.instance.i){
            //print("angle: " + main.instance.angle_counter);
            //print("vert: " + vert + "horz: " + horz);
			horz = (float)9.81 * Mathf.Cos(((main.instance.angle + main.instance.angle_counter)/180)*Mathf.PI);
            vert = (float)9.81 * Mathf.Sin(((main.instance.angle + main.instance.angle_counter) / 180) * Mathf.PI);
            Physics2D.gravity = new Vector2(horz, vert);
		}
        if (main.instance.j)
        {
            //print("angle: " + main.instance.angle_counter);
            //print("vert: " + vert + "horz: " + horz);
            horz = (float)9.81 * Mathf.Cos(((main.instance.angle + main.instance.angle_counter) / 180) * Mathf.PI);
            vert = (float)9.81 * Mathf.Sin(((main.instance.angle + main.instance.angle_counter) / 180) * Mathf.PI);
            Physics2D.gravity = new Vector2(horz, vert);
        }
    }
}
