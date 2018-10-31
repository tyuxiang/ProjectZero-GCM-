
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour {

    public gravity movement;

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "spikes")
        {
            movement.enabled = false;
            main.instance.angle = -90;
            main.instance.angle_counter = 0;
            Physics2D.gravity = new Vector2(0, (float)-9.81);
            Restart();
        }
       
        if (collisionInfo.gameObject.tag == "Enemy")
        {
            movement.enabled = false;
            main.instance.angle = -90;
            main.instance.angle_counter = 0;
            Physics2D.gravity = new Vector2(0, (float)-9.81);
            Restart();
        }

    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
