using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball;
    public GameObject player;
    public int count = 0;
    public float y_change = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ++count;

        transform.position = new Vector3(player.transform.position.x + 25f, 
            transform.position.y, transform.position.z);

        if (count == 60 || count == 120)
        {
            transform.position = new Vector3(player.transform.position.x,
                transform.position.y - y_change, transform.position.z);
            y_change = -1 * y_change;
        }

        if (count >= 180)
        {
            Instantiate(ball, transform.position, transform.rotation);
            count = 0;
        }
     

        if (transform.position.x < -10f)
        {
            Destroy(this);
        }
    }
}
