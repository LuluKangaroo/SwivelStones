using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        spawnStone();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnStone()
    {
        string[] stoneArr = GetRandomStoneCombo();
        GameObject newStone1 = (GameObject)Instantiate(Resources.Load(stoneArr[0], typeof(GameObject)), new Vector3(2, 10, -1), Quaternion.identity);
        GameObject newStone2 = (GameObject)Instantiate(Resources.Load(stoneArr[1], typeof(GameObject)), new Vector3(2, 11, -1), Quaternion.identity);

    }

    string[] GetRandomStoneCombo()
    {
        int randomStone1 = Random.Range(1, 5);
        int randomStone2 = Random.Range(1, 5);

        string stone1 = "";
        string stone2 = "";

        switch (randomStone1)
        {
            case 1:
                stone1 = "Prefabs/red";
                break;
            case 2:
                stone1 = "Prefabs/blue";
                break;
            case 3:
                stone1 = "Prefabs/green";
                break;
            case 4:
                stone1 = "Prefabs/yello";
                break;
        }
        switch (randomStone2)
        {
            case 1:
                stone2 = "Prefabs/red";
                break;
            case 2:
                stone2 = "Prefabs/blue";
                break;
            case 3:
                stone2 = "Prefabs/green";
                break;
            case 4:
                stone2 = "Prefabs/yello";
                break;
        }

        string[] ret = new string[2] { stone1, stone2 };
        return ret;
    }
}
