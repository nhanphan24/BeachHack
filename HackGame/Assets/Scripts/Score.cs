using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text score;
    static public int scoreInt = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        score.text = "HELLO";
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        score.text = "SCORE: " + scoreInt;
        if (scoreInt == 8)
        {
            score.text = "VICTORY!!";
            Application.Quit();
        }
    }
}
