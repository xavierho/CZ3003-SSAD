using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeavyCrush : MonoBehaviour
{
    public Sprite sprite1;
    public float tensec = 0.4f;
    public bool timer = false;
    public Rigidbody2D player;
    public GameObject cooldown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && cooldown.GetComponent<Cooldown>().CanUse == true)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
            timer = true;
            cooldown.GetComponent<Cooldown>().CanUse = false;
        }
        if (timer)
        {
            tensec -= Time.smoothDeltaTime;
            if (tensec < 0)
            {
                timer = false;
                gameObject.GetComponent<SpriteRenderer>().sprite = null;
                tensec = 0.4f;
            }
            Collider2D[] colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 0.3f);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject.tag == "Enemy" && colliders[i].gameObject.GetComponent<EnemyHit>())
                {
                    colliders[i].gameObject.GetComponent<EnemyHit>().Damage(50);
                    //if (player.GetComponent<PlayerHit>().currentHealth < player.GetComponent<PlayerHit>().MaxHealth - 10)
                    //{
                    //    player.GetComponent<PlayerHit>().currentHealth += 10;
                    //}
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(gameObject.transform.position, 0.3f);
    }
}
