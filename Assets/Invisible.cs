using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    public float maxtiming;
    private float tensec;
    public float maxtiming2;
    private float tensec2;
    private bool start = false;
    public Sprite sprite1;
    // Start is called before the first frame update
    void Start()
    {
        tensec = maxtiming;
        tensec2 = maxtiming2;
    }

    // Update is called once per frame
    void Update()
    {
        if (!start)
        {
            tensec -= Time.smoothDeltaTime;
            if (tensec < 0)
            {
                start = true;
                tensec = maxtiming;
            }
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else
        {
            tensec2 -= Time.smoothDeltaTime;
            if (tensec2 < 0)
            {
                tensec2 = maxtiming2;
                start = false;
            }
            gameObject.GetComponent<SpriteRenderer>().sprite = null;
        }
    }
}
