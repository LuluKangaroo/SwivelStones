using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/* 
 * An adapter for PlayerPrefs, to be used for leaderboard functionality
 * Leaderboard scores are stored in HS_S1, HS_S2, ...
 * Leaderboard names are stored in HS_N1, HS_N2, ...
 */
public class Leaderboard : MonoBehaviour
{
	// score of last game
	public static int last_score = 0;
	
	// maximum number of scores to be stored in the leaderboard
    public static int MAXSCORES = 8;

    public static int fetchScore(int pos)
    {
        return PlayerPrefs.GetInt("HS_S" + pos,0);
    }
    public static string fetchName(int pos)
    {
        return PlayerPrefs.GetString("HS_N" + pos,"---");
    }
    static void setScore(int pos, int score)
    {
        PlayerPrefs.SetInt("HS_S" + pos, score);
    }
    static void setName(int pos, string name)
    {
        PlayerPrefs.SetString("HS_N" + pos, name);
    }
    public static int calcPlace(int score)
    {
		/* calculates the place of the new score, 
		   or MAXSCORES+1 if not in leaderboard  */
        for (int i=1;i<=MAXSCORES;i++)
        {
            if (fetchScore(i) < score) return i;
        }
        return MAXSCORES + 1;
    }
    public static void addNew(int score, string name)
    {
		/* adds a new score with a name to the leaderboard, if possible */
        int p = calcPlace(score);
        if (p > MAXSCORES) return;
        for (int i=MAXSCORES;i>p;i--)
        {
            setScore(i, fetchScore(i - 1));
            setName(i, fetchName(i - 1));
        }
        setScore(p, score);
        setName(p, name);
    }
    public static string allPlaces()
    {
		/* returns a newline-separated string of all places */
        string a = "";
        for (int i=1;i<=MAXSCORES;i++)
        {
            a += i + ".\n";
        }
        return a;
    }
    public static string allNames()
    {
		/* returns a newline-separated string of all leaderboard names */
        string a = "";
        for (int i = 1; i <= MAXSCORES; i++)
        {
            a += fetchName(i) + "\n";
        }
        return a;
    }
    public static string allScores()
    {
		/* returns a newline-separated string of all leaderboard scores */
        string a = "";
        for (int i = 1; i <= MAXSCORES; i++)
        {
            a += fetchScore(i) + "\n";
        }
        return a;
    }
}
