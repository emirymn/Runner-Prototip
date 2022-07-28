using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchJumper : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            other.GetComponentInParent<Rigidbody>().velocity += 7f * Vector3.up;
    }
}
