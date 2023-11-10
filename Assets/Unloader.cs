using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unloader : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("port"))
        {
            GlobalEventManager.SendRubishDiscarded();
        }
    }
}
