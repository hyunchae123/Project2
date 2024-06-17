using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Stove : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Image[] HandFood = new Image[5];
    [SerializeField] ParticleSystem vfx;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (StoveTrigger.Instance.IsIn)
        {
            MakingWithTwoIngredient("eggs", "oil", "fried_egg");

            MakingWithTwoIngredient("straberry", "bread_roll", "strawberry_tart");

            MakingWithThreeIngredient("milk", "chocolate", "wheat", "cookie");

            MakingWithTwoIngredient("wheat", "water", "bread_roll");

            MakingWithOneIngredient("becone", "bacon");

            MakingWithThreeIngredient("bread_roll", "cabbage", "tomato", "sandwich");

            MakingWithThreeIngredient("ham", "cheese", "tomato", "pizza");

            MakingWithTwoIngredient("fish2", "oil", "steamed_fish");
        }
    }


    private void MakingWithOneIngredient(string Ingredient, string food)
    {
        for (int i = 0; i < HandFood.Length; i++)
        {
            if (HandFood[i].sprite.name.Equals(Ingredient))
            {
                HandFood[i].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                GameManager.Instance.inFood[i] = false;

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


    private void MakingWithThreeIngredient(string Ingredient1, string Ingredient2, string Ingredient3, string food)
    {

        for (int i = 0; i < HandFood.Length; i++)
        {
            if (HandFood[i].sprite.name.Equals(Ingredient1))
            {
                for (int j = 0; j < HandFood.Length; j++)
                {
                    if (HandFood[j].sprite.name.Equals(Ingredient2))
                    {
                        for (int w = 0; w < HandFood.Length; w++)
                        {
                            if (HandFood[w].sprite.name.Equals(Ingredient3))
                            {
                                HandFood[i].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                                GameManager.Instance.inFood[i] = false;
                                HandFood[j].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                                GameManager.Instance.inFood[j] = false;
                                HandFood[w].sprite = Resources.Load<Sprite>("Frame_Square_White_60px");
                                GameManager.Instance.inFood[w] = false;

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
                break;
            }
        }


    }
}
