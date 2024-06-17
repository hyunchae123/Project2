using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteFood : MonoBehaviour
{
    [SerializeField] Image foodIcon;
    [SerializeField] int HandNum;
    public void Delete()
    {
        foodIcon.sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
        GameManager.Instance.inFood[HandNum] = false;
    }
}
