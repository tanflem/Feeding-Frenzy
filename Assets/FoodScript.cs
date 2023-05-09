using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScript : MonoBehaviour
{
  public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
     logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        logic.addScore(1);
    }
}
 
