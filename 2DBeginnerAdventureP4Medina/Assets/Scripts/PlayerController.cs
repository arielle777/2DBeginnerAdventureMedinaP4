using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerControllerTutorialUpdates : MonoBehaviour
{
    public int maxHealth = 5;
    int currretnHealth;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public InputAction LeftAction;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody2d = GetComponent<Rigidbody2D>();
        currretnHealth = maxHealth;
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

   void FixedUpdate()
    {
        
     Vector2 position = rigidbody2d.position;
        position.x = position.x + 7.0f * horizontal * Time.deltaTime;
        position.y = position.y + 7.0f * vertical * Time.deltaTime;  
       rigidbody2d.MovePosition(position);
    }
    void ChangeHealth(int amount)
   
    }
}

