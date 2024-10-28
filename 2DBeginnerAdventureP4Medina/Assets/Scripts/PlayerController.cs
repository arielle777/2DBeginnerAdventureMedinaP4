using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;

public class PlayerControllerTutorialUpdates : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;
    public InputAction LeftAction;
    // Start is called before the first frame update
    void Start()
    {
       rigidbody2d=GetComponent<Rigidbody2D>();
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
        Vector2 position = transform.position;
        position
    }
}

