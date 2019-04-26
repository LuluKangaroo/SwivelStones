using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoToScoresList()
    {
        MenuManager.GoToMenu(MenuName.HighScores);
    }
    
    public void StartGame()
    {
        SceneManager.LoadScene("Scene");
    }
    
    public void ShowHelp()
    {
        MenuManager.GoToMenu(MenuName.Instructions);
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
}
