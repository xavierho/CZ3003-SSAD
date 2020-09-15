using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class MusicPlayer : MonoBehaviour
{
    /// <summary>
    /// The clip to play in a menu.
    /// This field is private because it's not designed to be directly
    /// modified by other scripts, and tagged with [SerializeField] so that
    /// you can still modify it using the Inspector and so that Unity
    /// saves its value.
    /// </summary>
    [SerializeField]
    private AudioClip Music1;

    /// <summary>
    /// The clip to play outside menus.
    /// </summary>
    [SerializeField]
    private AudioClip Music2;

    [SerializeField]
    private AudioClip Music3;

    [SerializeField]
    private AudioClip Music4;

    [SerializeField]
    private AudioClip Music5;

    [SerializeField]
    /// <summary>
    /// The component that plays the music
    /// </summary>
    private AudioSource source;

    /// <summary>
    /// This class follows the singleton pattern and this is its instance
    /// </summary>
    static private MusicPlayer instance;

    /// <summary>
    /// Awake is not public because other scripts have no reason to call it directly,
    /// only the Unity runtime does (and it can call protected and private methods).
    /// It is protected virtual so that possible subclasses may perform more specific
    /// tasks in their own Awake and still call this base method (It's like constructors
    /// in object-oriented languages but compatible with Unity's component-based stuff.
    /// </summary>
    protected virtual void Awake()
    {
        // Singleton enforcement
        if (instance == null)
        {
            // Register as singleton if first
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            // Self-destruct if another instance exists
            Destroy(this);
            return;
        }
    }

    protected virtual void Start()
    {
        // If the game starts in a menu scene, play the appropriate music
        PlayMusic1();
    }

    /// <summary>
    /// Plays the music designed for the menus
    /// This method is static so that it can be called from anywhere in the code.
    /// </summary>
    static public void PlayMusic1()
    {
        if (instance != null)
        {
            if (instance.source != null)
            {
                if (instance.source.clip != instance.Music1)
                {
                    instance.source.Stop();
                    instance.source.clip = instance.Music1;
                    instance.source.Play();
                }
            }
        }
        else
        {
            Debug.LogError("Unavailable MusicPlayer component");
        }
    }

    /// <summary>
    /// Plays the music designed for outside menus
    /// This method is static so that it can be called from anywhere in the code.
    /// </summary>
    static public void PlayMusic2()
    {
        if (instance != null)
        {
            if (instance.source != null)
            {
                if (instance.source.clip != instance.Music2)
                {
                    instance.source.Stop();
                    instance.source.clip = instance.Music2;
                    instance.source.Play();
                }
            }
        }
        else
        {
            Debug.LogError("Unavailable MusicPlayer component");
        }
    }

    static public void PlayMusic3()
    {
        if (instance != null)
        {
            if (instance.source != null)
            {
                if (instance.source.clip != instance.Music3)
                {
                    instance.source.Stop();
                    instance.source.clip = instance.Music3;
                    instance.source.Play();
                }
            }
        }
        else
        {
            Debug.LogError("Unavailable MusicPlayer component");
        }
    }

    static public void PlayMusic4()
    {
        if (instance != null)
        {
            if (instance.source != null)
            {
                if (instance.source.clip != instance.Music4)
                {
                    instance.source.Stop();
                    instance.source.clip = instance.Music4;
                    instance.source.Play();
                }
            }
        }
        else
        {
            Debug.LogError("Unavailable MusicPlayer component");
        }
    }

    static public void PlayMusic5()
    {
        if (instance != null)
        {
            if (instance.source != null)
            {
                if (instance.source.clip != instance.Music5)
                {
                    instance.source.Stop();
                    instance.source.clip = instance.Music5;
                    instance.source.Play();
                }
            }
        }
        else
        {
            Debug.LogError("Unavailable MusicPlayer component");
        }
    }
}
