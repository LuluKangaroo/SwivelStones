using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid: MonoBehaviour
{
    public static float gridHeight = 5;
    public static float gridWidth = 5;

    public float gridxy = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckUserInput();   
    } 

    void CheckUserInput()
    {
        if(Input.GetKeyDown(KeyCode.D)) // Shift Grid to the Right
        {
            if(gridxy < 2)
            {
                transform.position += new Vector3(1, 0, 0);
                gridxy++;
            }           
        }
        else if (Input.GetKeyDown(KeyCode.A)) //Shift Grid to the Left
        {
            if(gridxy > -2)
            {
                transform.position += new Vector3(-1, 0, 0);
                gridxy--;
            }            
        }
        else if(Input.GetKeyDown(KeyCode.W)) //Rotate Grid Counter-Clockwise
        {
            transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime);
        }
        else if(Input.GetKeyDown(KeyCode.S)) //Rotate Grid Clockwise
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 10 * Time.deltaTime);
        }
    }
}
