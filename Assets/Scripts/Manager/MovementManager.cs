using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public class MovementManager : MonoBehaviour
    {
        [SerializeField] float nosIncreaseSpeed;
        [SerializeField] GameObject Player;
        MoveForward moveForwardScript;
        [SerializeField] GameManager gameManager;
        [SerializeField] Swipee swipe;

        private void Awake()
        {
            moveForwardScript = Player.GetComponent<MoveForward>();
        }
        private void OnEnable()
        {
            StaticEvents.OnTakeNos += onTakeNos;
            StaticEvents.HitThorn += HitThorn;
            StaticEvents.HitObstable += HitObstable;
            StaticEvents.LevelWin += OnFinishEnter;

        }
        private void OnDisable()
        {
            StaticEvents.OnTakeNos -= HitThorn;
            StaticEvents.HitThorn -= HitThorn;
            StaticEvents.HitObstable -= HitObstable;
            StaticEvents.LevelWin -= OnFinishEnter;
        }
        public void onTakeNos()
        {
            moveForwardScript.moveSpeed += nosIncreaseSpeed;
        }
        public void HitThorn()
        {
            moveForwardScript.moveSpeed /= 2;
        }
        public void HitObstable()
        {
            gameManager.canMove = false;
            StaticEvents.LevelLoss?.Invoke();
        }
        public void OnFinishEnter()
        {
            gameManager.canMove = false;
        }
    }
