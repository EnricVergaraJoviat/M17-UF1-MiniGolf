using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
        Destroy(other.gameObject);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D");
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("OnTriggerExit2D");
    }
}
