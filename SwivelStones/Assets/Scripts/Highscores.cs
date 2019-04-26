using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscores : MonoBehaviour
{
    public Text numbers;
    public Text names;
    public Text scores;

    // Start is called before the first frame update
    void Start()
    {
        numbers.text = Leaderboard.allPlaces();
        names.text = Leaderboard.allNames();
        scores.text = Leaderboard.allScores();
    }

    public void toMainMenu()
    {
        MenuManager.GoToMenu(MenuName.MainMenu);
    }
}
