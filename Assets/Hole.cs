using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public Sprite sprite1;
    public float tensec = 0.8f;
    public bool timer = false;
    public GameObject cooldown;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && cooldown.GetComponent<Cooldown>().CanUse == true)
        {
            cooldown.GetComponent<Cooldown>().CanUse = false;
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
            timer = true;
        }
        if (timer)
        {
            tensec -= Time.smoothDeltaTime;
            if(tensec < 0)
            {
                timer = false;
                gameObject.GetComponent<SpriteRenderer>().sprite = null;
                tensec = 0.8f;
            }
            Collider2D[] colliders = Physics2D.OverlapCircleAll(gameObject.transform.position, 2.5f);
            for (int i = 0; i < colliders.Length; i++)
            {
                if (colliders[i].gameObject.tag == "Enemy" && colliders[i].gameObject.GetComponent<EnemyHit>())
                {
                    colliders[i].gameObject.GetComponent<EnemyHit>().Damage(25);
                }
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(gameObject.transform.position, 2.5f);
    }
}
