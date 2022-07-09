using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCalculation : MonoBehaviour
{
    public TMP_Text uIScore;
    private float score = 0;

    void Start()
    {
        score = 0;
        uIScore.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "coin")
        {
            //add score
            score ++;
            //show new score
            uIScore.text = score.ToString();
            //hide coin or destroy it 
            col.gameObject.SetActive(false);
        }
    }
}
