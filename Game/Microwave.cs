using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Microwave : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image[] HandFood = new Image[5];
    [SerializeField] ParticleSystem vfx;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (Cabinet1Trigger.Instance.IsIn)
        {
            MakingWithTwoIngredient("milk", "carrot", "soup");
        }
    }

    private void MakingWithTwoIngredient(string Ingredient1, string Ingredient2, string food)
    {
        for (int i = 0; i < HandFood.Length; i++)
        {
            if (HandFood[i].sprite.name.Equals(Ingredient1))
            {
                for (int j = 0; j < HandFood.Length; j++)
                {
                    if (HandFood[j].sprite.name.Equals(Ingredient2))
                    {
                        HandFood[i].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                        GameManager.Instance.inFood[i] = false;
                        HandFood[j].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                        GameManager.Instance.inFood[j] = false;

                        for (int k = 0; k < HandFood.Length; k++)
                        {
                            if (GameManager.Instance.inFood[k] == false)
                            {
                                HandFood[k].sprite = Resources.Load<Sprite>(food);
                                GameManager.Instance.inFood[k] = true;
                                vfx.Play();
                                break;
                            }
                        }
                        break;
                    }
                }
                break;
            }
        }

    }
}
