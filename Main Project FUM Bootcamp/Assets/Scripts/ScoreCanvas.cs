using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCanvas : MonoBehaviour
{
    [HideInInspector]
    public static int score = 0;

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score: " + score;
    }
}
