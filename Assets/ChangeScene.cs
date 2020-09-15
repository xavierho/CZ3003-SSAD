using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public int numOfEnemies;
    //public string scene;
    private float maxtiming = 5;
    private float timing;
    // Start is called before the first frame update
    void Start()
    {
        timing = maxtiming;
    }

    // Update is called once per frame
    void Update()
    {
        if(numOfEnemies == 0)
        {
            timing -= Time.smoothDeltaTime;
            if (timing < 0)
            {
                SaveSystem.SaveLevel(SceneManager.GetActiveScene().buildIndex);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
