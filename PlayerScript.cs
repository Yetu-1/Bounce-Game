using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float speed;
    public float jump_strength;
    public float direction_x;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction_x = Input.GetAxis("Horizontal");

        myRigidBody2D.velocity = new Vector2(direction_x * speed, myRigidBody2D.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody2D.AddForce(new Vector2(myRigidBody2D.velocity.x, jump_strength));
        }
    }
}
