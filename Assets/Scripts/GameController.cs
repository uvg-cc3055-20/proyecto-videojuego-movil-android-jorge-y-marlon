using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del juego. 
 */

public class GameController : MonoBehaviour {
    public bool gameOver = false;
    public int score = 0;
	public float time=0f ;
    public static GameController  instance; 
	public Text timeLabel;
	public Text coinLabel;

	public bool pause = false;

	// Use this for initialization
	void Start () {
        instance = this; 
	}
	
	// Update is called once per frame
	void Update () {
		//si el juego no se ha terminado, sigue sumando el tiempo en el contador del score
		if (gameOver == false ){
			
		if ( PauseMenu.instance.GameState == false){
			
		time += Time.deltaTime;
		PlayerPrefs.SetFloat("Time",time);	
		//modifica los label del tiempo y de las monedas
		timeLabel.text="Score: " + PlayerPrefs.GetFloat("Time").ToString("n2");
		coinLabel.text= "Coins: " + PlayerPrefs.GetInt("Coins").ToString("n2");
		
		
			
		}	
		
		
		}else{	
		
			GameOver.instance.gameOverPanel.SetActive(true);
		}	
	}
}
