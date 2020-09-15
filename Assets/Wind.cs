using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("Zetarian Knight");
        player.GetComponent<Rigidbody2D>().AddForce(new Vector2(x, y), ForceMode2D.Impulse);
    }
}
