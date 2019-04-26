using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaderboard : MonoBehaviour
{

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
        for (int i=1;i<=MAXSCORES;i++)
        {
            if (fetchScore(i) < score) return i;
        }
        return MAXSCORES + 1;
    }
    public static void addNew(int score, string name)
    {
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
        string a = "";
        for (int i=1;i<=MAXSCORES;i++)
        {
            a += i + ".\n";
        }
        return a;
    }
    public static string allNames()
    {
        string a = "";
        for (int i = 1; i <= MAXSCORES; i++)
        {
            a += fetchName(i) + "\n";
        }
        return a;
    }
    public static string allScores()
    {
        string a = "";
        for (int i = 1; i <= MAXSCORES; i++)
        {
            a += fetchScore(i) + "\n";
        }
        return a;
    }
}
