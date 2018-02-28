using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del obstaculo
 */

public class MoveRightObstacle : MonoBehaviour {
    Rigidbody2D rb;
    float speed = 5f;   
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
		//si el juego no se ha terminado y no esta en pausa sigue moviendo el obstaculo 
        if(GameController.instance.gameOver == false) {
            if (PauseMenu.instance.GameState == false) { 
                rb.transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (rb.transform.position.x > 7f)
        {
            Destroy(gameObject);
        }
    }
        }
}
}
