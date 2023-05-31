using System;
using System.Transactions;
// using System.Threading.Tasks.Dataflow;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject food;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        SpawnFood();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            SpawnFood();
        } 
    }

    void SpawnFood()
    {
        Vector3 boxSize = new Vector3(1000f, 1000f, 0f);

        // Get a random point inside the box.
        Vector3 randomBoxPoint = new Vector3(UnityEngine.Random.Range(-boxSize.x, boxSize.x), UnityEngine.Random.Range(-boxSize.y, boxSize.y), 0);

        // Instantiate the food object at the random point.
        Instantiate(food, randomBoxPoint, transform.rotation);

    }
}
