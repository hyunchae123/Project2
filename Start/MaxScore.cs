using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaxScore : MonoBehaviour
{
    [SerializeField] TMP_Text score;
    [SerializeField] ScoreInfo MyScore;

    void Start()
    {
        score.text = MyScore.MaxScore.ToString();
    }

    void Update()
    {
        
    }
}
