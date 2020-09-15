using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public Rigidbody2D bullet;
    public float moveSpeed = 5f;
    private Rigidbody2D bullet1;
    public GameObject player;
    float tensec = 3;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        tensec -= Time.smoothDeltaTime;
        if (tensec < 0)
        {
            Fire();
            tensec = 3;
        }
    }

    void Fire()
    {
        if (player.transform.localScale.x < 0)
        {
            bullet1 = Instantiate(bullet, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;
            Vector2 horizontalMove = new Vector2(7, 0);
            bullet1.GetComponent<Rigidbody2D>().velocity = horizontalMove;
        }
        else if (player.transform.localScale.x > 0)
        {
            bullet1 = Instantiate(bullet, new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;
            Vector2 horizontalMove = new Vector2(-7, 0);
            bullet1.GetComponent<Rigidbody2D>().velocity = horizontalMove;
        }
        else
        {

        }
    }
}
