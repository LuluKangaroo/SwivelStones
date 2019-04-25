using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    void Start()
    {
        // pause the game when added to the scene
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        // unpause game and destroy menu
        Time.timeScale = 1;
        Destroy(gameObject);
    }

    public void QuitGame()
    {
        // unpause game, destroy menu, and go to main menu
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.MainMenu);
    }
}
