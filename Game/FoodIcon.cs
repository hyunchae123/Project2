using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodIcon : MonoBehaviour
{
    [SerializeField] Image foodIocn;

    [SerializeField] Image[] HandFood = new Image[5];


    public void SelectFood()
    {
        for(int i = 0; i < 5; i ++)
        {
            if (GameManager.Instance.inFood[i] == false)
            {
                HandFood[i].sprite = foodIocn.sprite;
                GameManager.Instance.inFood[i] = true;
                break;
            }
        }

    }
}
