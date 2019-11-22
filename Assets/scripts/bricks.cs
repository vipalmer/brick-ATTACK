using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class bricks : MonoBehaviour
{
    public float speed;
    private Quaternion initialRotation;
    private Vector3 initialPosition;
    private object go;

    void Update()
    {
        transform.Translate(-Time.deltaTime * speed, 0, 0);
    }
   
}


