﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float delayInSec;
    [SerializeField] private Transform parent;
    [SerializeField] private Vector3 initialPosition;
    [SerializeField] private Vector3 fieldSize;
    [SerializeField] private Vector3 initialForce;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke(nameof(Spawn),delayInSec);
        InvokeRepeating(nameof(Spawn), delayInSec, delayInSec);
    }
    void Spawn()
    {
        var newBallPosition = parent.position;
        Instantiate(ballPrefab, newBallPosition, Quaternion.identity, parent);
        var newBallBody = GetComponent<Rigidbody>();
        if (newBallBody == null) return;
        newBallBody.AddForce(initialForce);
        //Invoke(nameof(Spawn), delayInSec);
    }
}
