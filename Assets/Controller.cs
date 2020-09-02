using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 10.0f;
    public bool jump = true;
    private int jumpHeight = 0;
    private int maxJumpHeight = 1;

    public bool onGround = false;

    public GameData data;

    public Controller()
    {
        data = new GameData();
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start Controller for Player");
        
    }
    

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        print(translation.ToString());
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed");
        }

        // Make it move 10 meters per second instead of 10 meters per frame...
        if (jump)
        {
            if (jumpHeight <= maxJumpHeight / 2)
            {
                jumpHeight++;
            }
            else
            {
                jumpHeight--;
            }
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;
        }

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);

        // Rotate around our y-axis
        transform.Rotate(0, rotation, 0);
    }

    void StartJump()
    {
        if (onGround)
        {
            jump = true;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent<SphereCollider>(out SphereCollider spherePlaceholder))
        {
            data.Collect(collision.gameObject);
        }
        else if (collision.gameObject.TryGetComponent<Terrain>(out Terrain terrainPlaceholder))
        {
            onGround = true;
            jump = false;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        onGround = false;
    }
}