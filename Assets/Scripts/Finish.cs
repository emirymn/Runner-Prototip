using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Finish : MonoBehaviour
{
    [SerializeField] float jumpPower;
    [SerializeField] float jumpTime;
    [SerializeField] GameObject player;
    [SerializeField] Transform targetPos;
    private void OnEnable()
    {
        StaticEvents.LevelWin += OnFinish;

    }
    private void OnDisable()
    {
        StaticEvents.LevelWin -= OnFinish;
    }
    void OnFinish()
    {
          player.transform.DOJump(targetPos.position, jumpPower, 0, jumpTime);
       // player.transform.DOLocalMove(targetPos.localPosition, jumpTime);

    }
}
