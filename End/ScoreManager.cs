using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] ScoreInfo Mysocre;

    void Start()
    {
        scoreText.text = Mysocre.score.ToString();
    }

}
