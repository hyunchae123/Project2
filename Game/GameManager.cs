using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{

    public bool[] Chair = new bool[5];

    public bool[] inFood = new bool[5];

    [SerializeField] Image[] HandFood = new Image[5];

    public bool recipeIsOpen;

    [SerializeField] TMP_Text timeText;
    [SerializeField] float limitTime;


    void Start()
    {
        recipeIsOpen = false;

        for (int i = 0; i < 5; i++)
            Chair[i] = false;

        for(int i = 0; i < 5; i++)
        {
            inFood[i] = false;
        }


        for(int i = 0; i < 5; i++)
        {
            HandFood[i].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
        }

        TimeSpan span = TimeSpan.FromSeconds(limitTime);
        timeText.text = span.ToString(@"mm\:ss");
    }

    private void Update()
    {
        limitTime -= Time.deltaTime;

        TimeSpan span = TimeSpan.FromSeconds(limitTime);
        timeText.text = span.ToString(@"mm\:ss");

        if(limitTime <= 0.0f)
            SceneManager.LoadScene("End");
    }

    public void inChair(int ChairNum)
    {
        Chair[ChairNum - 1] = true;

    }

    public void outChair(int ChairNum)
    {
        Chair[ChairNum - 1] = false;

    }

    public bool CheckChair(int Num)
    {
        return Chair[Num - 1];

    }
}
