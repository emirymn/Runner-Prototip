using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    #region Instance
    [HideInInspector]
    public static LevelManager instance = null;
    #endregion

    [SerializeField] private TMP_Text levelCountTxt;
    public int currentLevel = 1;
    public int[] levelRequirements;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this) Destroy(gameObject);
    }

    private void Start()
    {
        currentLevel = PlayerPrefs.GetInt(PlayerPrefsHelper.LAST_LEVEL_PREFS_NAME, 0) + 1;

        SetLevelUI();
    }

    private void SetLevelUI()
    {
        var nextLevel = currentLevel + 1;
        levelCountTxt.text = "Level " + currentLevel;
    }

    public void LevelCompleted()
    {
        GameManager.instance.gameStatuses = GameStatuses.Stopped;
        GameManager.instance.levelCompletedScreen.SetActive(true);

        PlayerPrefs.SetInt(PlayerPrefsHelper.LAST_LEVEL_PREFS_NAME, currentLevel);
        
    }
}