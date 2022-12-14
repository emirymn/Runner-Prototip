using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class TotalUIController : MonoBehaviour
{
    [SerializeField] GameObject Player;
    int Level;
    [Header("Texts")]
    [SerializeField] TextMeshProUGUI totalPointText;
    [SerializeField] TextMeshProUGUI PointText;
    [SerializeField] TextMeshPro PlayerInGameLevelText;
    [SerializeField] TextMeshProUGUI LevelText;
    [Header("Script Managers")]
    [SerializeField] MoveForward moveForward;
    [SerializeField] GameManager gameManager;
    [SerializeField] MovementManager movementManager;
    [SerializeField] PlayerController playerControllerScript;
    [Header("Panels")]
    [SerializeField] GameObject MainMenu;
    [SerializeField] GameObject inGame;
    [SerializeField] GameObject LevelEnd;
    [SerializeField] GameObject LevelWin;
    [SerializeField] GameObject LevelLoss;
    [SerializeField] GameObject PlayBeforeScreen;
    [Space]

    private int point;
    private void Awake()
    {
        MainMenu.SetActive(true);
    }
    private void OnEnable()
    {
        StaticEvents.OnFinish += PointSystem;
        StaticEvents.GameStart += UIStartController;
        StaticEvents.LevelLoss += UILevelLoss;
        StaticEvents.LevelFinish += UILevelEnd;
        StaticEvents.LevelWin += UILevelWin;
        StaticEvents.EatFood += PlayerEATFood;
        StaticEvents.InLevelPortal += PlayerInPortal;
        StaticEvents.TakeLwUPCollectables += TakeLwUPCollectable;
        StaticEvents.NextLevel += UINextLevel;
    }
    private void OnDisable()
    {
        StaticEvents.OnFinish -= PointSystem;
        StaticEvents.GameStart -= UIStartController;
        StaticEvents.LevelLoss -= UILevelLoss;
        StaticEvents.LevelFinish -= UILevelEnd;
        StaticEvents.LevelWin -= UILevelWin;
        StaticEvents.EatFood -= PlayerEATFood;
        StaticEvents.InLevelPortal -= PlayerInPortal;
        StaticEvents.TakeLwUPCollectables -= TakeLwUPCollectable;
        StaticEvents.NextLevel -= UINextLevel;
    }
    #region puan sistemi
    private void PointSystem(int whichColor)
    {
        if (whichColor == 1)
        {
            PointText.text = point + 50 + "";
            movementManager.OnFinishEnter();
        }
        else if (whichColor == 2)
        {
            PointText.text = point + 100 + "";
            movementManager.OnFinishEnter();
        }
        else if (whichColor == 3)
        {
            PointText.text = point + 150 + "";
            movementManager.OnFinishEnter();
        }
        else if (whichColor == 4)
        {
            PointText.text = point + 200 + "";
            movementManager.OnFinishEnter();
        }
        else if (whichColor == 5)
        {
            PointText.text = point + 250 + "";
            movementManager.OnFinishEnter();
        }
    }
    #endregion
    #region UI Start End Loss Win
    private void UIStartController()
    {
        PlayerInGameLevelText.gameObject.SetActive(true);
        gameManager.canMove = true;
        MainMenu.SetActive(false);
        inGame.SetActive(true);
        Level = PlayerPrefs.GetInt("Level",Level);
        LevelText.text = "Level: " + Level;
    }
    private void UILevelEnd()
    {
        gameManager.canMove = false;
        inGame.SetActive(false);
        LevelEnd.SetActive(true);
    }
    private void UILevelLoss()
    {
        gameManager.canMove = false;
        inGame.SetActive(false);
        LevelLoss.SetActive(true);
    }
    private void UILevelWin()
    {
        gameManager.canMove = false;
        inGame.SetActive(false);
        LevelWin.SetActive(true);

    }
    private void UINextLevel()
    {
        LevelWin.SetActive(false);
        PlayBeforeScreen.SetActive(true);
    }
    public void PlayBeforeScreenClose()
    {
        PlayBeforeScreen.SetActive(false);
        inGame.SetActive(true);
        gameManager.canMove = true;
        
    }
    #endregion
    #region Player Level
    void PlayerEATFood()
    {
        playerControllerScript.playerInGameLevel++;
        PlayerInGameLevelText.text = "Level : " + playerControllerScript.playerInGameLevel;
        playerControllerScript.PlayerModelChange();
    }
    void PlayerInPortal(int value)
    {
        playerControllerScript.playerInGameLevel += value;
        PlayerInGameLevelText.text = "Level : " + playerControllerScript.playerInGameLevel;
        playerControllerScript.PlayerModelChange();
    }
    void TakeLwUPCollectable()
    {
        playerControllerScript.playerInGameLevel++;
        PlayerInGameLevelText.text = "Level : " + playerControllerScript.playerInGameLevel;
        playerControllerScript.PlayerModelChange();
    }
    #endregion
}

