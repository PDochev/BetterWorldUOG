using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlobalEventManager
{
    public static UnityEvent OnCollected = new UnityEvent();
    public static UnityEvent OnDiscard = new UnityEvent();

    public static void SendRubbishCollected()
    {
        OnCollected.Invoke();
    }

    public static void SendRubishDiscarded()
    {
        OnDiscard.Invoke();
    }
}
