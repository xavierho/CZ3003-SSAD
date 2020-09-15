using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public float maxtiming;
    private float timing;
    public bool CanUse = true;
    // Start is called before the first frame update
    void Start()
    {
        timing = maxtiming;
    }

    // Update is called once per frame
    void Update()
    {
        if (CanUse == false)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
            timing -= Time.smoothDeltaTime;
            if (timing < 0)
            {
                CanUse = true;
                gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
                timing = maxtiming;
            }
        }
    }
}
