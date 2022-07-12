using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] AudioClip[] clips;
    AudioSource source;
    public static Music Instance { get; private set; }
    
    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        source = GetComponent<AudioSource>();

    }
    void Start()
    {
        source.clip = clips[0];
        source.Play();
        if(FindObjectOfType<Music>() )
        DontDestroyOnLoad(Instance);
    }


    // Update is called once per frame
    void Update()
    {
        if(source.isPlaying == false)
        {
            playRandomMusic();
        }

    }
    void playRandomMusic()
    {
        source.clip = clips[Random.Range(0, clips.Length)] ;
        source.Play();
    }
}
