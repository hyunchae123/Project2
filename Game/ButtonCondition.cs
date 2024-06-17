using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ButtonCondition : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image[] HandFood = new Image[5];
    [SerializeField] SpriteRenderer speechBubble;
    [SerializeField] SpriteRenderer food;

    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < 5; i++)
        {
            if (food.sprite.Equals(HandFood[i].sprite))
            {
                speechBubble.enabled = false;
                food.enabled = false;
                HandFood[i].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                GameManager.Instance.inFood[i] = false;
                break;
            }
        }
    }

}
