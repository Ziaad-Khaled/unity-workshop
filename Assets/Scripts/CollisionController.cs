using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with " + other.gameObject.name);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected with " + other.gameObject.name);
    }
}
