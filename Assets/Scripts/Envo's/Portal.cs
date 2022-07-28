using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] int portalLevelIncrease;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            StaticEvents.InLevelPortal?.Invoke(portalLevelIncrease);
    }
}
