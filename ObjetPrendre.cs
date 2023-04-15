using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class ObjetPrendre : MonoBehaviour
{
    //private int nbObj;
    public nbobjets nbobjet;
    int val=0;
    public TextMeshProUGUI textDisplay;

    public AudioClip sound; // son à jouer

    [Range (0f, 1f)]
    public float volume;

    [Range (0.1f, 2.5f)]
    public float pitch; // vitesse du morceau 

    private AudioSource source; //il recoit tous les paramètres au dessus



    public void OnCollisionEnter (Collision infoCollision)
    {
        if (/*UnityEngine.Input.GetKeyDown("e") && */ (infoCollision.gameObject.name=="Capsule"))
        {
            nbobjet.nbObj +=1;
            source.Play();
            Destroy(this.gameObject, 2);
            Debug.Log("ici2" + nbobjet.nbObj);
            if(nbobjet.nbObj<7)
            {
                val = 7-nbobjet.nbObj;
                textDisplay.text = "Objets : " + nbobjet.nbObj+ "/7";
            }
            else if(nbobjet.nbObj==7)
            {
                textDisplay.text = "Trouver la sortie !";
            }
            
        } 
    }

    void Start()
    {
        source.clip=sound;
        source.volume=volume;
        source.pitch=pitch;
        textDisplay.text = "Objets : " + nbobjet.nbObj+ "/7";
    }

    void Awake()
    {
        gameObject.AddComponent<AudioSource>(); // On ajoute au cube le component Audio Source 
        source = GetComponent<AudioSource>(); // On affect a "source" ledit component

        volume=0.5f;
        pitch=1f;
        
    }
    void Update()
    {
        source.volume=volume;
        source.pitch=pitch;
    }
}
