using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    public float horizontalMove = 0f;
    bool jump = false;
    bool C = false;
    bool X = false;
    public bool hitwall = true;
    Vector2 newposition;
    public GameObject cooldown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump = true;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            C = true;
        }
        if(Input.GetKeyDown(KeyCode.F) && cooldown.GetComponent<Cooldown>().CanUse == true)
        {
            X = true;
        }
    }

    void FixedUpdate()
    {
        if(C == false && X == false)
        {
            controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        }
        else if(C == true && X == false)
        {
            if(horizontalMove != 0)
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalMove * 2, 0);
            }
            else
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 8f);
            }
        }
        else if(X==true && C == false)
        {
            if(horizontalMove > 0)
            {
                newposition = new Vector2(transform.position.x + 5f, transform.position.y);
            }
            else if(horizontalMove < 0)
            {
                newposition = new Vector2(transform.position.x - 5f, transform.position.y);
            }
            //else if(down)
            //{
            //    newposition = new Vector2(transform.position.x, transform.position.y - 5f);
            //}
            else
            {
                newposition = new Vector2(transform.position.x, transform.position.y + 5f);
            }
            CheckEmpty();
            if (hitwall)
            {
                transform.position = newposition;
                cooldown.GetComponent<Cooldown>().CanUse = false;
            }
        }
        jump = false;
        C = false;
        X = false;
    }

    private void CheckEmpty()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(newposition, 0.01f);
        if(colliders.Length == 0)
        {
            hitwall = true;
        }
        else
        {
            hitwall = false;
        }
    }
}
