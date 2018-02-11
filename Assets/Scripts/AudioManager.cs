using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {
    private AudioSource music;
    void Start()
    {
        music = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (SceneManager.GetActiveScene().Equals("CupheadGame"))
        {
            Destroy(music);
        }
        if (SceneManager.GetActiveScene().Equals("AngelGame"))
        {
            Destroy(music);
        }
        else
        {
            DontDestroyOnLoad(music);
        }
        

    }
}
