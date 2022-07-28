using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishColorDedector : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "blue")
        {
            StaticEvents.OnFinish?.Invoke(1);
            StaticEvents.LevelFinish?.Invoke();
        }
        if (other.gameObject.tag == "green")
        {
            StaticEvents.OnFinish?.Invoke(2);
            StaticEvents.LevelFinish?.Invoke();
        }
        if (other.gameObject.tag == "yellow")
        {
            StaticEvents.OnFinish?.Invoke(3);
            StaticEvents.LevelFinish?.Invoke();
        }
        if (other.gameObject.tag == "red")
        {
            StaticEvents.OnFinish?.Invoke(4);
            StaticEvents.LevelFinish?.Invoke();
        }
        if (other.gameObject.tag == "purple")
        {
            StaticEvents.OnFinish?.Invoke(5);
            StaticEvents.LevelFinish?.Invoke();
        }
    }
}
