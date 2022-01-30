using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Droper : MonoBehaviour
{
    [Header("Time Settings")]
    [SerializeField] public float awaitTime = 3f;

    private Rigidbody dropObstacleRB;
    private MeshRenderer dropObstacleMesh;

    private void Awake()
    {
        dropObstacleRB = GetComponent<Rigidbody>();
        dropObstacleMesh = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        dropObstacleMesh.enabled = false;
        dropObstacleRB.useGravity = false;
    }

    void Update()
    {
        if(Time.time >= awaitTime)
        {
            dropObstacleMesh.enabled = true;
            dropObstacleRB.useGravity = true;
        }
    }
}
