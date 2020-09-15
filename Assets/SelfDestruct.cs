﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Zetarian Knight")
        {

            GameObject game = GameObject.Find("Main Camera");
            game.GetComponent<ChangeScene>().numOfEnemies--;
            //collision.collider.GetComponent<PlayerHit>().Damage(5);
            Destroy(gameObject);
        }
    }
}
