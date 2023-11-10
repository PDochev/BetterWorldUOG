using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : MonoBehaviour
{
    public static bool isCollected = false;
    public GameObject fishNetPrefab;
    public Transform fishNetpos;
    public float fishNetSpeed = 15f;

    private void Awake()
    {
        GlobalEventManager.OnCollected.AddListener(Collect);
        GlobalEventManager.OnDiscard.AddListener(Discard);
    }

    void Collect()
    {
        isCollected = true;
    }

    void Discard()
    {
        isCollected = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject fishnet = Instantiate(fishNetPrefab, fishNetpos.position, Quaternion.identity);
            fishnet.GetComponent<Rigidbody>().AddForce(transform.forward * fishNetSpeed, ForceMode.Impulse);
            Destroy(fishnet, 2);
        }
    }
}