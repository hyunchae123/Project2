using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RefTrigger : Singleton<RefTrigger>
{
    public bool IsIn;

    private void Start()
    {
        IsIn = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other != null && other.gameObject.CompareTag("Player"))
            IsIn = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other != null && other.gameObject.CompareTag("Player"))
            IsIn = false;
    }
}
