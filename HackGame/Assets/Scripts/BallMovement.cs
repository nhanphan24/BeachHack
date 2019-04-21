using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public int count = 0;
    public Rigidbody2D myRigidBody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ++count;
        transform.position = new Vector3(transform.position.x - 0.2f, transform.position.y, transform.position.z);

        if (count == 120)
        {
            myRigidBody.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
            count = 0;
        }
    }
}
