using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control de la pausa. 
 */

public class PauseMenu : MonoBehaviour {
    public static PauseMenu instance;
    public  bool GameState = false;
    public GameObject pauseMenuUI;
    public GameObject button;
    void Start()
    {
        instance = this;
    }
    // Update is called once per frame
    /*void Update () {
        if (GameState)
        {
            Resume();
        }
        else
        {
            Pause();
        }
	}*/
	
	//si esta en pausa, activa el menu, quita el boton y marca la variable de pausa 
    public void Pause (){

        pauseMenuUI.SetActive(true);
        GameState = true;
        button.SetActive(false);
    }
}
