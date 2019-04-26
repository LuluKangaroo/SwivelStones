using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Menu Manager Interface
/// Contains method to access all scenes within the application
/// 
/// Author: Lulu Liu
/// </summary>
public static class MenuManager
{
    // Method to Load specific scene dependent on parameter
    // param = name of desired Scene, appointed my MenuName enum
    public static void GoToMenu(MenuName menu)
    {
        switch (menu)
        {
            case MenuName.HighScores:

                // case to go to Scores Menu scene
                SceneManager.LoadScene("HighScores");
                break;

            case MenuName.NewScore:

                // case to go to New Scores Menu scene
                SceneManager.LoadScene("NewHighScore");
                break;

            case MenuName.MainMenu:

                // case to go to Main Menu scene
                SceneManager.LoadScene("MainMenu");
                break;

            case MenuName.Pause:

                // case to instantiate Pause Menu prefab overlay
                Object.Instantiate(Resources.Load("PauseMenu"));
                break;

            case MenuName.Level:

                // case to go to GamePlay scene
                SceneManager.LoadScene("GamePlay");
                break;
        }
    }
}
