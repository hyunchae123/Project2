using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CoffeeMaker : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image[] HandFood = new Image[5];
    [SerializeField] ParticleSystem vfx;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Cabinet1Trigger.Instance.IsIn)
        {
            MakingCoffee();
        }
    }

    private void MakingCoffee()
    {
        for (int i = 0; i < HandFood.Length; i++)
        {
            if (HandFood[i].sprite.name.Equals("coffee1"))
            {
                HandFood[i].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                GameManager.Instance.inFood[i] = false;

                for (int k = 0; k < HandFood.Length; k++)
                {
                    if (GameManager.Instance.inFood[k] == false)
                    {
                        HandFood[k].sprite = Resources.Load<Sprite>("coffee");
                        GameManager.Instance.inFood[k] = true;
                        vfx.Play();
                        break;
                    }
                }
                break;
            }
        }
    }
}
