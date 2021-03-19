using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        ScoreText.text = "Score: " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D coin)
    {
        if (coin.tag == "MyCoin")
        {
            ScoreNum += 1;
            Destroy(coin.gameObject);
            ScoreText.text = "Score: " + ScoreNum;
        }
    }
}