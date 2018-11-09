using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public float minX = -29.5f;
    public float maxX = -11.6f;
    public float minY = -12.9f;
    public float maxY = -7.1f;
    public Transform player;

    void LateUpdate()
    {
        //Vector3 newPosition = player.position;
        //newPosition.z = transform.position.z;
        transform.position = new Vector3(Mathf.Clamp(player.transform.position.x, minX, maxX), Mathf.Clamp(player.transform.position.y, minY, maxY), transform.position.z);
    }

}