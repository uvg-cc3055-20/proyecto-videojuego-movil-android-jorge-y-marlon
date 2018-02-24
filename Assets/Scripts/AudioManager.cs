using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
