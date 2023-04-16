using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    public AudioClip sound; // son à jouer

    [Range (0f, 1f)]
    public float volume;

    [Range (0.1f, 2.5f)]
    public float pitch; // vitesse du morceau 

    private AudioSource source; //il recoit tous les paramètres au dessus

    void Awake()
    {
        gameObject.AddComponent<AudioSource>(); // On ajoute au cube le component Audio Source 
        source = GetComponent<AudioSource>(); // On affect a "source" ledit component

        volume=0.5f;
        pitch=1f;
    }
    // Start is called before the first frame update
    void Start()
    {
        source.clip=sound;
        source.volume=volume;
        source.pitch=pitch;
        if(!source.isPlaying)
        {
            source.Play();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(UnityEngine.Input.GetKeyDown("space"))
        {
            PlayAndPause();
        }
        source.volume=volume;
        source.pitch=pitch;
    }

    public void PlayAndPause()
    {
        if(!source.isPlaying)
        {
            source.Play();
        }
        else 
        {
            source.Pause();
        }
    }
}
