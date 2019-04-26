using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Pause Menu Class
/// Script to manager pause screen behaviors
/// 
/// Author: Lulu Liu
/// </summary>
public class PauseMenu : MonoBehaviour
{
    // Inherited method from Unity's MonoBehavior
    // Called right at start of object's creation
    void Start()
    {
        // pause the game when added to the scene
        Time.timeScale = 0;
    }

    // Method to resume back to the gameplay
    public void ResumeGame()
    {
        // unpause game and destroy menu
        Time.timeScale = 1;
        Destroy(gameObject);
    }

    // Method to redirect user to Main menu
    public void QuitGame()
    {
        // unpause game, destroy menu, and go to main menu
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.NewScore);
    }
}
