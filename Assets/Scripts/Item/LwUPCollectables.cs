using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LwUPCollectables : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StaticEvents.TakeLwUPCollectables?.Invoke();
            Destroy(gameObject);

        }
    }
}


