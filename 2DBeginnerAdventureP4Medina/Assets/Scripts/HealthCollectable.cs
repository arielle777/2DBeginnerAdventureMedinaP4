using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
   void OnTriggerEnter2D(Collider2D other)
    {
        PlayerControllerTutorialUpdates  controller = other.GetComponent<PlayerControllerTutorialUpdates>();
        if (controller != null)
        {
            if (controller.health < controller.maxHealth)
            {
                controller.ChangeHealth(1);
                Destroy(gameObject);
            }
        }
    
    }
}

