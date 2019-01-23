using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static int currentLevel = 1;

    public static void completeLevel()
    {
        if (currentLevel < 3)
        {
            currentLevel += 1;
            SceneManager.LoadScene(currentLevel);
        }
        else if(currentLevel == 4)
        {
            Application.Quit();
        }
    }
}
