using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Main Menu Class
/// Script to manage button behaviors within the Main Menu
/// 
/// Author: Lulu Liu
/// </summary>
public class MainMenu : MonoBehaviour
{
    // Method to direct application to Scores scene
    public void GoToScoresList()
    {
        MenuManager.GoToMenu(MenuName.HighScores);
    }

    // Method to direct application to GamePlay scene
    public void StartGame()
    {
        MenuManager.GoToMenu(MenuName.Level);
    }

    // Method to exit the application
    public void ExitGame()
    {
        Application.Quit();
    }
}
