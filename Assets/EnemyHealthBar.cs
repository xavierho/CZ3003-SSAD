using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    public GameObject player;
    public float percent;
    public float health;
    public float maxhealth;
    public GameObject healthbar;
    // Start is called before the first frame update
    void Start()
    {
        //PLAYER = GameObject.Find("Zetarian Knight");
        health = player.GetComponent<EnemyHit>().currentHealth;
        maxhealth = player.GetComponent<EnemyHit>().MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        health = player.GetComponent<EnemyHit>().currentHealth;
        percent = health / maxhealth;
        Vector3 theScale = healthbar.transform.localScale;
        theScale.x = percent;
        healthbar.transform.localScale = theScale;
    }
}
