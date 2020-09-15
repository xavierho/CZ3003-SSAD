using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public int num;
    // Start is called before the first frame update
    void Start()
    {
        switch (num)
        {
            case (1):
                MusicPlayer.PlayMusic1();
                break;
            case (2):
                MusicPlayer.PlayMusic2();
                break;
            case (3):
                MusicPlayer.PlayMusic3();
                break;
            case (4):
                MusicPlayer.PlayMusic4();
                break;
            case (5):
                MusicPlayer.PlayMusic5();
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
