using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del audio
 */

public class AudioManager : MonoBehaviour {
    public static AudioSource myAudio;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();  
    }
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
