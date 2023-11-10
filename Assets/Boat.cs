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
    public GameObject load;

    private void Awake()
    {
        load.SetActive(false);
        GlobalEventManager.OnCollected.AddListener(Collect);
        GlobalEventManager.OnDiscard.AddListener(Discard);
    }

    void Collect()
    {
        load.SetActive(true);
        isCollected = true;
    }

    void Discard()
    {
        load.SetActive(false);
        isCollected = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject fishnet = Instantiate(fishNetPrefab, fishNetpos.position, transform.rotation);
            fishnet.GetComponent<Rigidbody>().AddForce(transform.forward * fishNetSpeed, ForceMode.Impulse);
            Destroy(fishnet, 2);
        }
    }
}