using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveTrigger : Singleton<StoveTrigger>
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
