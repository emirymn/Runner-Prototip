using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitThorn : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            StaticEvents.HitThorn?.Invoke();
    }
}
