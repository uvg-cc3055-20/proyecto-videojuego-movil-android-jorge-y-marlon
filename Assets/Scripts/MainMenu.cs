using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control menu principal 
 */

public class MainMenu : MonoBehaviour {


//opciones del menu principal 
    public void PlayGame()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
	
	public void Credits(){
		SceneManager.LoadScene("Credits");
		
	}
	
}
