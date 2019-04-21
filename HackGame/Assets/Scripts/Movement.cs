using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 7f;
    public float jump = 4f;
    public int jumpCount = 0;
    public bool left = false;
    public bool right = true;
    // Update is called once per frame
    void FixedUpdate()
    {
        
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        if (transform.position.x < -3.8f && horizontalInput == -1)
        {
            horizontalInput = 0;
        }

        transform.position = new Vector3(
            transform.position.x + (speed * horizontalInput * Time.deltaTime),
            transform.position.y,
            transform.position.z);

        if (horizontalInput == -1 && left == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            left = true;
            right = false;
        }

        else if (horizontalInput == 1 && right == false)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            right = true;
            left = false;
        }

        else if (horizontalInput == 1 && right == true && jumpCount > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D myRigidBody = gameObject.GetComponent<Rigidbody2D>();
            if (myRigidBody != null)
            {
                if (jumpCount < 2)
                {
                    ++jumpCount;
                    myRigidBody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
                }

                else if (transform.position.y < 0f)
                {
                    jumpCount = 0;
                }
            }
        }
    }
}
