using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Ref : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] GameObject RefImage;

    public bool isOpen;

    private void Start()
    {
        isOpen = false;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(!isOpen && RefTrigger.Instance.IsIn == true)
        {
            RefImage.SetActive(true);
            isOpen = true;
        }
            
        else
        {
            RefImage.SetActive(false);
            isOpen = false;
        }
            
        

       
    }
}
