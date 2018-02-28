using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del spawn de monedas
 */

public class CoinSpawner : MonoBehaviour {

	 public GameObject coin;
    float spawnTime = 4f;
	float elapsedTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GameController.instance.gameOver == false)
        {
		if (elapsedTime < spawnTime)
		{
			elapsedTime += Time.deltaTime;
		}
		else {
			float random = Random.Range(-2f, 2f);
			Instantiate(coin, new Vector3(8, random, 0),
			Quaternion.identity);
			elapsedTime = 0;
		}
		}
		
	}
}
