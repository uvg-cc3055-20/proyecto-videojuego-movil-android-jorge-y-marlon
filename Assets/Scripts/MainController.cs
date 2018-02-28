using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainController : MonoBehaviour {
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del score en el menu principal
 */

public Text score;

	// Use this for initialization
	void Start () {
		
//hace que el "label" de texto en la pantalla principal muestre el punteo maximo que se tiene en el juego	
		//pone el default
		score.text ="HighScore: "+ PlayerPrefs.GetFloat("score").ToString();
	}
	
	// Update is called once per frame
	void Update () {
			
			
			//obtengo el tiempo
			float ptime = GameController.instance.time;
			//si el record es menor que el tiempo actual se cambian y se guarda
			if (GameController.instance.time > PlayerPrefs.GetFloat("score")){
				
				PlayerPrefs.SetFloat("score",ptime);		
				PlayerPrefs.Save();
			}
			
			
			
			//se despliega el valor del puntaje maximo 
			score.text = "HighScore: "+ PlayerPrefs.GetFloat("score").ToString("n2");
	}
}
