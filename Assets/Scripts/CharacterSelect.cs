using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour {

    public void PlayCuphead()
    {
        SceneManager.LoadScene("CupheadGame");
        AudioManager.myAudio.Stop();
    }
    public void PlayAngel()
    {
        SceneManager.LoadScene("AngelGame");
        AudioManager.myAudio.Stop();
    }
}
