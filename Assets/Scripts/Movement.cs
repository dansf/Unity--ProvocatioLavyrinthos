using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Moviment Settings")]
    [SerializeField] float speedPlayer = 10f;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xValue = (Input.GetAxis("Horizontal") * speedPlayer) * Time.deltaTime;
        float zValue = (Input.GetAxis("Vertical") * speedPlayer) * Time.deltaTime;
        
        transform.Translate(xValue, 0, zValue);
    }
}
