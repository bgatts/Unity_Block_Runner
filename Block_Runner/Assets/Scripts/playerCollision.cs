using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour
{
    public NewBehaviourScript movment;

    void OnCollisionEnter( Collision collisionInfo)
	{
        if(collisionInfo.collider.tag == "Obstacle")
		{
            movment.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            


		}
    }
}
