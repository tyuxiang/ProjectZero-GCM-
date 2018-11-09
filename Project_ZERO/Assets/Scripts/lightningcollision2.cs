using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class lightningcollision2 : MonoBehaviour
{
    public float lightningtimer2;

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

        if (lightningtimer2 < 3)
        {
            lightningtimer2 += 1 * Time.deltaTime;
        }

        if (lightningtimer2 >= 3)
        {
            Destroy(gameObject);


        }
    }

}
