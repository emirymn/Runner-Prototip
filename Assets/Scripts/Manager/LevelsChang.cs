using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsChang : MonoBehaviour
{

    public int level,maxlevel,levelControl;

    public GameObject[] levels;

    // Start is called before the first frame update
    void Start()
    {
        levels[0].SetActive(false);
    }

    public void randomNumber()
    {
        level = Random.Range(0, maxlevel);

    }

    // Update is called once per frame
    void Update()
    {
        if(level < 0 || level>= maxlevel+1)
        {
            level = 0;
        }
        levelControl++;
        if (levelControl>maxlevel-1||levelControl<0)
        {
            levelControl = 0;
        }
        

        if (level==levelControl)
        {
            levels[levelControl].SetActive(true);
        }
        else
        {
            levels[levelControl].SetActive(false);
        }

    }
}
