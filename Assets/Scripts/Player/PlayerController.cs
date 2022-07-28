using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerInGameLevel = 1;
    private int playerModelCount = 0;
    [SerializeField] private GameObject[] playerModels;

    private void Awake()
    {
        PlayerModelChange();
    }
    public void PlayerModelChange()
    {
        if (playerInGameLevel < 10)
        {
            playerModelCount = 0;
            playerModels[playerModelCount].SetActive(true);
        }
        else if (playerInGameLevel < 20)
        {
            if (playerModels[playerModelCount] == null || playerModelCount == 1)
                return;

            playerModelCount = 1;
            PlayerModelsActived();
        }
        else if (playerInGameLevel < 30)
        {
            if (playerModels[playerModelCount] == null || playerModelCount == 2)
                return;

            playerModelCount = 2;
            PlayerModelsActived();
        }
        else if (playerInGameLevel < 40)
        {
            if (playerModels[playerModelCount] == null || playerModelCount == 3)
                return;

            playerModelCount = 3;
            PlayerModelsActived();
        }
        else if (playerInGameLevel < 50)
        {
            if (playerModels[playerModelCount] == null || playerModelCount == 4)
                return;

            playerModelCount = 4;
            PlayerModelsActived();
        }
        else if (playerInGameLevel < 60)
        {
            if (playerModels[playerModelCount] == null || playerModelCount == 5)
                return;

            playerModelCount = 5;
            PlayerModelsActived();
        }
        else if (playerInGameLevel < 75)
        {
            if (playerModels[playerModelCount] == null || playerModelCount == 6)
                return;

            playerModelCount = 6;
            PlayerModelsActived();
        }
        else if (playerInGameLevel < 100)
        {
            
            if (playerModels[playerModelCount] == null || playerModelCount == 7)
                return;

            playerModelCount = 7;
            PlayerModelsActived();
        }
        
    }
   private void PlayerModelsActived()
    {
        playerModels[playerModelCount - 1].SetActive(false);
        playerModels[playerModelCount].SetActive(true);
    }
}
