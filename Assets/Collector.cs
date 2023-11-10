using UnityEngine;

public class Collector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("rubbish")) return;
        GlobalEventManager.SendRubbishCollected();
        Destroy(other.gameObject);

    }
}
