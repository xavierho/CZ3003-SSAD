using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Rigidbody2D bulletflip;
    public float moveSpeed = 5f;
    private Rigidbody2D bullet1;
    private Rigidbody2D bullet2;
    public GameObject player;
    public GameObject cooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && cooldown.GetComponent<Cooldown>().CanUse == true)
        {
            Fire();
            cooldown.GetComponent<Cooldown>().CanUse = false;
        }
        if (bullet1)
        {
            Vector2 horizontalMove = new Vector2(9, 0);
            bullet1.GetComponent<Rigidbody2D>().velocity = horizontalMove;
        }
        if (bullet2)
        {
            Vector2 horizontalMove = new Vector2(-9, 0);
            bullet2.GetComponent<Rigidbody2D>().velocity = horizontalMove;
        }
    }
    
    void Fire()
    {
        if(player.transform.localScale.x > 0)
        {
            bullet1 = Instantiate(bullet, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;
        }
        else if (player.transform.localScale.x < 0)
        {
            bullet2 = Instantiate(bulletflip, new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;
        }
    }
}
