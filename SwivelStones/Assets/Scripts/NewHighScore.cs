using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewHighScore : MonoBehaviour
{
    public Text ranking;
    public Text inputName;
    int rank;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        score = getScore();
        rank = Leaderboard.calcPlace(score);
        if (rank>Leaderboard.MAXSCORES)
        {
            SceneManager.LoadScene("HighScores");
        }
        else
        {
            ranking.text = score + " points - rank " + rank;
        }
    }

    int getScore()
    {
        // TODO        
        return Timer.scoreValue;
    }

    public void submit()
    {
        Leaderboard.addNew(score, inputName.text);
        SceneManager.LoadScene("HighScores");
    }
    public void ignoreScore()
    {
        SceneManager.LoadScene("HighScores");
    }
}
