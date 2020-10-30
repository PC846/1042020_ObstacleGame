using UnityEngine;

public class Player_Collision : MonoBehaviour
{

    public Player_Move movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.name);
       

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            Debug.Log(collisionInfo.collider.name);
            
        }
    }
}
