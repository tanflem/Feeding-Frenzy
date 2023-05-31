using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    public float size;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (target != null) {
            Vector3 lookPos = target.transform.position;
            lookPos.z = -10f;
            transform.position = lookPos;
        }
    }
    
    // LateUpdate is called after all of the other update methods have been called
    void LateUpdate() {
            Camera.main.orthographicSize = Mathf.Abs(target.transform.localScale.x) * 10;        
    }
}
