using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHit : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    private float tensec = 0.2f;
    public bool timer = false;
    bool CanBeHit = true;
    public float MaxHealth = 100;
    public float currentHealth;
    public float maxtiming;
    private float timing;
    private bool freeze = false;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = MaxHealth;
        timing = maxtiming;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        if (timer && currentHealth > 0)
        {
            if (CanBeHit)
            {
                CanBeHit = false;
            }
            if (!freeze)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
            }
            tensec -= Time.smoothDeltaTime;
            if (tensec < 0)
            {
                timer = false;
                gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
                tensec = 0.2f;
                CanBeHit = true;
            }
        }
        if (freeze)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite3;
            timing -= Time.deltaTime;
            if (timing < 0)
            {
                freeze = false;
                gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                timing = maxtiming;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.collider.tag == "Enemy")
        {
            Damage(5);
        }
    }

    public void Damage(int damage)
    {
        timer = true;
        tensec = 0.2f;
        if (CanBeHit)
        {
            currentHealth -= damage;
        }
    }
    
    public void Freeze()
    {
        freeze = true;
    }
}
