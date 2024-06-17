using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class food
{
    public int Score;
    public string name;
    public Sprite icon;

    public food(int Score, string name, Sprite icon)
    {
        this.name = name;
        this.icon = icon;
        this.Score = Score;
    }
}
