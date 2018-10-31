using UnityEngine;

public class endtrigger : MonoBehaviour 
{

    public GameManager Gamemanager;

    private void OnTriggerEnter2D()
    {
        Gamemanager.Completelevel();
    }
    

}
