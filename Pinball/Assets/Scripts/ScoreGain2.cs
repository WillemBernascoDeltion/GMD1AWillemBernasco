﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreGain2 : MonoBehaviour
{

    public Text scoreText;
    public static int scoreGainUp;

    void Update()
    {
        scoreText.text = "Score: " + scoreGainUp;
    }
}
