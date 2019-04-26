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

    void Start()
    {
		/* checks if new score should be added or not
		   if yes, display score and rank and continue to allow
		   user to enter name/ignore score.
		   if no, go directly to highscores
		 */
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
        // TODO: gets score of last game
        return 123;
    }

    public void submit()
    {
		// submits new score and goes to highscore screen
        Leaderboard.addNew(score, inputName.text);
        SceneManager.LoadScene("HighScores");
    }
    public void ignoreScore()
    {
		// ignore new score, go directly to highscore screen
        SceneManager.LoadScene("HighScores");
    }
}
