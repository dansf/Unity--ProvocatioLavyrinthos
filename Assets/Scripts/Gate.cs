using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    Collider colliderGate;
    MeshRenderer meshGate;

    [SerializeField] Collider colliderGateBlock;
    [SerializeField] GameObject gameObjGateBlock;
    
    private void Awake()
    {
        colliderGate = GetComponent<Collider>();
        meshGate = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        colliderGate.isTrigger = true;
        meshGate.enabled = false;
        colliderGateBlock.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        colliderGateBlock.enabled = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if(Time.time >= 0.5)
        {
            colliderGate.isTrigger = false;
            meshGate.enabled = true;

            Destroy(gameObjGateBlock);
        }
    }
}
