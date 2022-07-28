using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float moveSpeed;
   [SerializeField] GameManager gameManager;
  
      void Update()
    {
        if(gameManager.canMove)
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
