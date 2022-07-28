using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
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

    public bool canMove = false; 
    public void GameStarted()
    {
        StaticEvents.GameStart?.Invoke();
    }
}
