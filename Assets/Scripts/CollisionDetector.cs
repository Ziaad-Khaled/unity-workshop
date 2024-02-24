using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeText;
    private MeshRenderer meshRenderer;
    private Rigidbody rigidbody;
    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Time.time > 3)
        {
            rigidbody.useGravity = true;
        }
        else
        {
            timeText.text = "Time: " + Time.time;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision detected with " + other.gameObject.tag);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger detected with " + other.gameObject.tag);
        if (other.gameObject.tag == "Wall")
        {
            meshRenderer.material.color = Color.red;
        }
    }
}
