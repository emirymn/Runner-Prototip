using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeNos : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StaticEvents.OnTakeNos?.Invoke();
            Destroy(this.gameObject, 0.01f);
        }
    }
}
