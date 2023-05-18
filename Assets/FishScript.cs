using System.Diagnostics;
//using Microsoft.CSharp.RuntimeBinder;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishScript : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D rb;
    public float swimStrength;
    public bool birdIsAlive = true;
    public float growAmount = 1.1f;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {

        // Move in any direction with WASD or arrow keys
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = Vector2.up * swimStrength;

        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if( transform.localScale.x > 0)
            {
                transform.localScale = new Vector3(-1 * transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
            rb.velocity = Vector2.left * swimStrength;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = Vector2.down * swimStrength;

        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.localScale.x < 0)
            {
                transform.localScale = new Vector3(-1 * transform.localScale.x, transform.localScale.y, transform.localScale.z);
            }
            rb.velocity = Vector2.right * swimStrength;
        }
    }
    // OnCollisionEnter is called when the sprite collides with another object.
    void OnTriggerEnter2D (Collider2D targetObj) {
        if(targetObj.gameObject.tag == "Resistance")
        {
                Destroy(targetObj.gameObject);
        }

        UnityEngine.Debug.Log(targetObj.name);

        // If the object that the sprite collided with is the specific sprite that you want it to grow, then grow the sprite.
        if (targetObj.name == "food(Clone)") {

            // Increase the sprite's size by the growAmount.
            transform.localScale = transform.localScale * growAmount;
        }
    }
}