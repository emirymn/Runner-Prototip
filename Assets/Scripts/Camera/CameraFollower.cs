using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] Transform target;
    [Space]
    [SerializeField] private float moveSpeed;
    [Space]
    [SerializeField] private Vector3 followOffset;
    [SerializeField] private Vector3 rotationOffset;

    #region EDITOR
    private void OnValidate()
    {
        if (target != null)
        {
            transform.position = target.position + followOffset;
        }
        transform.eulerAngles = rotationOffset;
    }
    #endregion

    #region MonoBehaviour METHODS
    private void LateUpdate()
    {
        Movement();
    }
    #endregion

    private void Movement()
    {
        if (target == null) return;

        Vector3 targetPos = target.position + followOffset;
        transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
    }
}