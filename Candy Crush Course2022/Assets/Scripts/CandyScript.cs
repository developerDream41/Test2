﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyScript : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag=="Player")
        {
            // score
            GameManager.instance.IncrementScore();
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
}
