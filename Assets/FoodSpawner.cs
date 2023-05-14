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
         // Get the camera object.
    Camera camera = Camera.main;

    // Get the size of the camera's view frustum.
    Vector3 size = camera.WorldToScreenPoint(Vector3.zero) - camera.WorldToScreenPoint(new Vector3(1, 1, 1));

    // Get a random point outside the camera's view frustum.
    Vector3 randomPoint = new Vector3(UnityEngine.Random.Range(-size.x, size.x), UnityEngine.Random.Range(-size.y, size.y), 0);

    // Instantiate the food object at the random point.
    Instantiate(food, randomPoint, transform.rotation);
    }
}
