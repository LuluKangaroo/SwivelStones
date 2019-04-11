using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapesSpawner : MonoBehaviour
{
    public GameObject[] shapes;
    public void spawnShape()
    {
        int shapeIndex = Random.Range(0, 3);

        Instantiate (shapes[shapeIndex],
            transform.position,
            Quaternion.identity);
    }
    // Start is called before the first frame update
    void Start()
    {
        spawnShape();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
