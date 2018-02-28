using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del jfondo
 */

public class InfiniteBackground : MonoBehaviour {
    float scrollingSpeed = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//si no se ha terminado el juego y no esta en pausa
        if(GameController.instance.gameOver == false){ 
        if (PauseMenu.instance.GameState == false) { 
        transform.Translate(new Vector3(1, 0, 0) * -scrollingSpeed * Time.deltaTime);
        if (transform.position.x < -12f)
        {
            transform.position = new Vector3(1f, transform.position.y, transform.position.z);
        }
    }
    }
    }
}
