using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GetRings : MonoBehaviour
{

    static public GameObject ring0;
    static public GameObject ring1;
    static public GameObject ring2;
    static public GameObject ring3;
    static public GameObject ring4;
    static public GameObject ring5;
    static public GameObject ring6;
    static public GameObject ring7;

    public List<GameObject> allRings = new List<GameObject> { ring0, ring1, ring2, ring3, ring4, ring5, ring6, ring7 };
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (var ring in allRings)
        {
            if (Math.Abs(transform.position.x - ring.transform.position.x) <= 1 &&
                Math.Abs(transform.position.y - ring.transform.position.y) <= 1)
            {
                allRings.Remove(ring);
                Destroy(ring);
                ++Score.scoreInt;
                break;
            }
        }
    }
}
