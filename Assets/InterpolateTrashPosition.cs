using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolateTrashPosition : MonoBehaviour
{
    
    void Update()
    {
        transform.position = Vector3.Lerp(Vector3.up, Vector3.forward, 1);
    }
}
