using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public float tensec = 0.2f;
    public bool timer = false;
    public bool CanBeHit = true;
    public int MaxHealth = 300;
    public int currentHealth;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth <= 0)
        {
            //gameObject.GetComponent<SpriteRenderer>().sprite = null;
            GameObject game = GameObject.Find("Main Camera");
            game.GetComponent<ChangeScene>().numOfEnemies--;
            Destroy(gameObject);
        }
        if (timer && currentHealth > 0)
        {
            if (CanBeHit)
            {
                CanBeHit = false;
            }
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;            
            tensec -= Time.smoothDeltaTime;
            if (tensec < 0)
            {
                timer = false;
                gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
                tensec = 0.2f;
                CanBeHit = true;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.collider.tag == "Player Attack")
        {
            timer = true;
            tensec = 0.2f;
        }
    }

    public void Damage(int damage)
    {
        timer = true;
        tensec = 0.2f;
        if (CanBeHit)
        {
            currentHealth -= damage;
            Debug.Log(currentHealth);
        }
    }
}
