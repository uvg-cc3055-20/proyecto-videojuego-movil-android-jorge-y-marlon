using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control y opciones de menu de pausa
 */

public class PauseMenuOptions : MonoBehaviour {
    public void Resume()
    {
        PauseMenu.instance.GameState = false;
        PauseMenu.instance.pauseMenuUI.SetActive(false);
        PauseMenu.instance.button.SetActive(true);

    }
	//despliega las opciones en el menu de pausa
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void CharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }
}
