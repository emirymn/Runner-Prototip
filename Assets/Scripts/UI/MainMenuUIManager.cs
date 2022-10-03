using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUIManager : MonoBehaviour
{
    [SerializeField] GameObject MainMenu, Us, Shop;

    public void PlayButton()
    {
        SceneManager.LoadScene("TestScene");
    }
    public void BackButton()
    {

    }
    public void ShopOpenButton()
    {
        Shop.gameObject.SetActive(true);
        MainMenu.gameObject.SetActive(false);
    }
   public void UsOpenButton()
    {
        Us.gameObject.SetActive(true);
        MainMenu.gameObject.SetActive(false);
    }
}
