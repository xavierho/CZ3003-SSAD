using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlip : MonoBehaviour
{
    public GameObject player;
    public float num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 Position = player.transform.position;
        Vector2 now = transform.position;
        if (Position.x < now.x)
        {
            Vector2 theScale = transform.localScale;
            theScale.x = num;
            transform.localScale = theScale;
        }
        else
        {
            Vector2 theScale = transform.localScale;
            theScale.x = num * -1;
            transform.localScale = theScale;
        }
    }
}
