using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    float cumulativeScore = 0;

    public void CumulativeScore(float num)
    {
        cumulativeScore += num;
        scoreText.text = "" + cumulativeScore;
    }
}
