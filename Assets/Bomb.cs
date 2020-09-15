using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public Rigidbody2D bomb;
    private Rigidbody2D bomb1;
    public int num;
    public GameObject cooldown;
    //public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && cooldown.GetComponent<Cooldown>().CanUse == true)
        {
            Drop();
            cooldown.GetComponent<Cooldown>().CanUse = false;
        }
        if (!bomb1)
        {
            num = 0;
        }
    }

    void Drop()
    {
        if (num == 0)
        {
            if(transform.localScale.x > 0)
            {
                bomb1 = Instantiate(bomb, new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;
            }
            else
            {
                bomb1 = Instantiate(bomb, new Vector3(transform.position.x - 1f, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;
            }
            num++;
        }
    }
}
