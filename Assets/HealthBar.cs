using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public GameObject player;
    public float percent;
    public float health;
    public float maxhealth;
    public GameObject healthbar;

    // Start is called before the first frame update
    void Start()
    {
        health = player.GetComponent<PlayerHit>().currentHealth;
        maxhealth = player.GetComponent<PlayerHit>().MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health = player.GetComponent<PlayerHit>().currentHealth;
        percent = health / maxhealth;
        Vector3 theScale = healthbar.transform.localScale;
        theScale.x = percent;
        healthbar.transform.localScale = theScale;
    }
}
