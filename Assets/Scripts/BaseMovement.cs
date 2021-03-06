﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del movimiento de los enemigos. 
 */

public class BaseMovement : MonoBehaviour {

    Rigidbody2D rb;
    float speed = 5f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		//si el juego no ha terminado y no esta en pausa, sigue el movimiento
        if (GameController.instance.gameOver == false) {
            if (PauseMenu.instance.GameState == false) { 
                rb.transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (rb.transform.position.x <-8f)
             {
                 Destroy(gameObject);
             }
	}
    }
}
}
