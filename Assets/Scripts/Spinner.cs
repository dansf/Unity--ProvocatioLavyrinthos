using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Header("Rotation Settings")]
    [SerializeField] float xRotation = 0;
    [SerializeField] float yRotation = 0.7f;
    [SerializeField] float zRotation = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotation, yRotation, zRotation);
    }
}
