using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    float fall = 0;
    public float fallSpeed = 1;
    bool grounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Gravity();
    }
    
    void Gravity()
    {
        if (Time.time - fall >= fallSpeed)
        {           
            transform.position += new Vector3(0, -1, 0);
            fall = Time.time;
            if (!CheckPosition())
            {
                transform.position += new Vector3(0, 1, 0);
                if(CheckBelow())
                {
                    FindObjectOfType<Dispenser>().SpawnStone();
                    enabled = false; //temporary fix
                }
            }
        }
    }
    
    Vector2 GetCoords()
    {
        Vector3 pos = transform.position;
        Vector2 ret = pos;
        return ret;
    }
    
    bool CheckPosition()
    {
        if (FindObjectOfType<Grid>().InsideGrid(GetCoords()) == false)
        {
            return false;
        }
        return true;
    }

    /*
    bool IsGrounded()
    {
        if transform.position.y == 0
    }
    */

    bool CheckBelow()
    {
        if(transform.position.y == 0)
        {
            return true;
        }
        //else if()
        return false;
    }
}
