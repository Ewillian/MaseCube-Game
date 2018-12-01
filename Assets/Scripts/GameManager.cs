using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static int currentLevel = 0;

    public static void completeLevel()
    {
        if (currentLevel < 2)
        {
            currentLevel += 1;
            SceneManager.LoadScene(currentLevel);
        }
    }
}
