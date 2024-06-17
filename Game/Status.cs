using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Status : MonoBehaviour
{
    [SerializeField] TMP_Text ScoreText;
    [SerializeField] ScoreInfo myScore;
    int score;
    int preSocre;
    
    private void Start()
    {
        score = 0;
        ScoreText.text = score.ToString();

        preSocre = myScore.score;
    }

    private void Update()
    {
        if(this.score > preSocre)
            myScore.MaxScore = this.score;

        myScore.score = this.score;
    }

    public void GetExp(int amount)
    {
        score += amount;
        ScoreText.text = score.ToString();
    }
}
