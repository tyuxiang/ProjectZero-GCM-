using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class faneffect : MonoBehaviour {
    public float fanmagnitude;
    public Vector2 direction;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(fanmagnitude*direction.normalized);
        }
    }
    
}
