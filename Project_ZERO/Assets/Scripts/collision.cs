
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour {
    public Rigidbody2D rb;
    public gravity movement;
    public float poweruptimer;
    private bool mortal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
        }

private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "spikes")
        {
            //movement.enabled = false;
            main.instance.angle = -90;
            main.instance.angle_counter = 0;
            Physics2D.gravity = new Vector2(0, (float)-9.81);
            Restart();
        }

        if (collisionInfo.gameObject.tag == "Enemy")
        {
            if(poweruptimer<1) 
            {
                movement.enabled = false;
                main.instance.angle = -90;
                main.instance.angle_counter = 0;
                Physics2D.gravity = new Vector2(0, (float)-9.81);
                Restart();
            }
            else{
                Destroy(collisionInfo.collider.gameObject);
            }

        }

        if(collisionInfo.gameObject.tag =="Powerup")
        {
            poweruptimer += 11;
            Destroy(collisionInfo.collider.gameObject);
        }
        if(collisionInfo.gameObject.tag=="secret"){
            Destroy(collisionInfo.collider.gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       // if(collision.gameObject.tag=="fan")
       // {
       //     rb.AddForce(-100F *rb.velocity);
        //}
    }

    
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    private void Update()
    {
        if (poweruptimer>0)
        {
            poweruptimer -= 1 * Time.deltaTime;
        }

    }
    
}
