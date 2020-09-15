using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraDamage : MonoBehaviour
{
    public int damage;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.name == "Zetarian Knight")
        {
            collision.collider.GetComponent<PlayerHit>().Damage(damage);
        }
    }
}
