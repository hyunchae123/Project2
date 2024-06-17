using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recipe : MonoBehaviour
{
    [SerializeField] GameObject Rec;
    public void OpenCloseRecipe()
    {
        if(GameManager.Instance.recipeIsOpen == false)
        {
            Rec.SetActive(true);
            GameManager.Instance.recipeIsOpen = true;
        }
        else
        {
            Rec.SetActive(false);
            GameManager.Instance.recipeIsOpen = false;
        }
        
    }

}
