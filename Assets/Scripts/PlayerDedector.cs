using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDedector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            StaticEvents.LevelWin?.Invoke();
        }
    }
}
