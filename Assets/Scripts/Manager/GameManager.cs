using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] GameObject[] Levels;
    [SerializeField] GameObject Player;
    [SerializeField] Transform startTransform;
    [SerializeField] MoveForward moveForward;
    [SerializeField] PlayerController playerController;
    int Level;
    #region Instance
    [HideInInspector]
    public static GameManager instance = null;
    #endregion  
    #region Menüler ama kullanýlmayacak
    public GameStatuses gameStatuses;

    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject gameScreen;
    [SerializeField]
    private GameObject gameOverScreen;
    public GameObject levelCompletedScreen;
    public GameObject cameraFallow;
    #endregion
    private void Awake()
    {
        PlayerPrefs.SetInt("Level", Level);
    }
    public bool canMove = false;
    public void GameStarted()
    {
        StaticEvents.GameStart?.Invoke();
    }
    public void NextLevel()
    {
        StaticEvents.NextLevel?.Invoke();
        Levels[Level].SetActive(false);
        Player.transform.position = startTransform.position;
        if (Level > 10)
            Level = 0;
        Level++;
        Levels[Level].SetActive(true);
        moveForward.moveSpeed = 10;
        playerController.playerInGameLevel = 1;
    }

}
