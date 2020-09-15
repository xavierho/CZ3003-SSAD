using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            Data data = SaveSystem.LoadLevel();
            if (data == null)
            {
                SceneManager.LoadScene(1);
            }
            if (data.GetVersion() != 1305200144)
            {
                SceneManager.LoadScene(1);
            }
            else
            {
                SceneManager.LoadScene(data.GetNum());
            }
        }
    }
}
