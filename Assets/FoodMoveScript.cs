using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -45;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        // Get the player's position.
        Vector3 playerPosition = GameObject.Find("Fish").transform.position;

        // Get the direction from the food object to the player.
        Vector3 direction = playerPosition - transform.position;

        // Normalize the direction vector.
        direction.Normalize();

        // Move the food object in the direction of the player.
        transform.Translate(direction * moveSpeed * Time.deltaTime);

        // transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
        // if (transform.position.x < deadZone)
        // {
        //     Destroy(gameObject);
        // }   
    }
}
