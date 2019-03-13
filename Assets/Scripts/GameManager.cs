using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static int currentLevel = 1;
    public int countCoin = 0;
    void Start(){
        DontDestroyOnLoad(gameObject);
    }
    public void addCoin(){
        countCoin += 1;
    }
    public void completeLevel()
    {
        if (currentLevel < 3)
        {
            currentLevel += 1;
            SceneManager.LoadScene(currentLevel);
        }
        else if(currentLevel == 3 && countCoin >= 4)
        {
            SceneManager.LoadScene(5);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }
}
