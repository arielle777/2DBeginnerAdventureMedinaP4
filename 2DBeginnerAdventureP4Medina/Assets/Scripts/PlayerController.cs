using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerControllerTutorialUpdates : MonoBehaviour
{
    public float speed = 7.0f;
    public int maxHealth = 5;
    public float timeInvicible = 5;
    public int health { get { return currentHealth; } }
    int currentHealth;


    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public InputAction LeftAction;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        currentHealth = 1;
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
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
    


