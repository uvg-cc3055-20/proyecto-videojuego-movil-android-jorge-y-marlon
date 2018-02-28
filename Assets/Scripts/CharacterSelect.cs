using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control de seleccion de personaje. 
 */

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
