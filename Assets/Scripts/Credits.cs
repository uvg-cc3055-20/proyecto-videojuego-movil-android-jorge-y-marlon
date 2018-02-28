using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra la forma de regresar al menu desde los creditos
 */

public class Credits : MonoBehaviour {

	// Use this for initialization
	 public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
