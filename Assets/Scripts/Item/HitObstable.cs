using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitObstable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            StaticEvents.HitObstable?.Invoke();
    }
}
