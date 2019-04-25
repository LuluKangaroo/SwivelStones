using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverMessage : MonoBehaviour
{
    
    void Start()
    {
        // pause the game when added to the scene
        Time.timeScale = 0;
    }
  
    public void HandleQuitButtonClicked()
    {
        // unpause game, destroy menu, and go to main menu
        Time.timeScale = 1;
        Destroy(gameObject);
        MenuManager.GoToMenu(MenuName.MainMenu);
    }
}
