using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject gameoverscreen;   // reference for the gameoverscreen object


    public void GameOver()
    {
        gameoverscreen.SetActive(true);     //function that actiavtes the game over screen
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);                  //function for the play again button 
    }
}
