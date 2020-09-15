using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeMovement : MonoBehaviour
{
    public float maxtiming;
    private float tensec;
    private bool freeze = false;
    //public Sprite sprite1;
    //public Sprite sprite2;
    // Start is called before the first frame update
    void Start()
    {
        tensec = maxtiming;
    }

    // Update is called once per frame
    void Update()
    {
        if (freeze)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            //gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
            tensec -= Time.deltaTime;
            if(tensec < 0)
            {
                freeze = false;
                //gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
                tensec = maxtiming;
            }
        }
    }

    public void Freeze()
    {
        freeze = true;
    }
}
