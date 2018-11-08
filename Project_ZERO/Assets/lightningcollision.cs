using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class lightningcollision : MonoBehaviour {
    public float lightningtimer;
    public float respawntimer;
    public GameObject lightningone;
    public Transform lightningposition;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Restart();
        }
    }
    // Update is called once per frame
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }





    private void Update()
    {

        if (lightningtimer < 3)
        {
            lightningtimer += 1 * Time.deltaTime;
        }

        if (lightningtimer >= 3)
        {
            Destroy(gameObject);
           

        }
    }

}
