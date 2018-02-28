using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del juego. 
 */

public class GameOver : MonoBehaviour {
	
	//instancia de game over y panel de gameover 
    public static GameOver instance;
    public GameObject gameOverPanel;
    private void Start()
    {
        instance = this;
    }

	//si perdio llama al panel, si selecciona continuar, descuenta 5 monedas y hace que llegue a la pantalla de selecciona
	//si no tiene monedas simplemente lo lleva al menu principal
    public void CharacterSelect()
	
    {
		
        SceneManager.LoadScene("CharacterSelect");
		PlayerPrefs.SetInt("Coins",PlayerPrefs.GetInt("Coins")-5);	
		if (PlayerPrefs.GetInt("Coins")<0){
			SceneManager.LoadScene("MainMenu");
			PlayerPrefs.SetInt("Coins",0);
		}
    }
	
	//si dice que no desea continuar lo lleva al menu 
    public void Quit()
    {
		SceneManager.LoadScene("MainMenu");    
	}
}
