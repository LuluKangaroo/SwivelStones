using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class MenuManager
{
    public static void GoToMenu(MenuName menu)
    {
        switch (menu)
        {
            case MenuName.HighScores:

                // go to Scores Menu scene
                SceneManager.LoadScene("HighScores");
                break;

            case MenuName.Instructions:

                // go to Help Menu scene
                SceneManager.LoadScene("Instructions");
                break;

            case MenuName.MainMenu:

                // go to Main Menu scene
                SceneManager.LoadScene("MainMenu");
                break;

            case MenuName.Pause:

                // instantiate prefab
                Object.Instantiate(Resources.Load("PauseMenu"));
                break;

            case MenuName.GameOver:

                // instantiate prefab
                SceneManager.LoadScene("GameOver");
                break;

            case MenuName.Level:

                // instantiate prefab
                SceneManager.LoadScene("Level");
                break;
        }
    }
}
