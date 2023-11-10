using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InstantiateOceanTrash : MonoBehaviour
{
    public GameObject[] trash;
    public Transform[] instatiatePositions;

    private void Awake()
    {
        GlobalEventManager.OnDiscard.AddListener(InstantiateTrash);
        InstantiateTrash();
    }

    void InstantiateTrash()
    {
        int number1 = Random.Range(0, trash.Length);
        print(number1);
        int number2 = Random.Range(0, instatiatePositions.Length);
        print(number2);
        Instantiate(trash[number1], instatiatePositions[number2].position, Quaternion.identity);
    }
}
