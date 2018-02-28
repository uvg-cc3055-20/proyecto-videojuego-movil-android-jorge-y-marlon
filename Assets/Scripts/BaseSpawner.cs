using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del spawn de los enemigos
 */

public class BaseSpawner : MonoBehaviour {

    public List<GameObject> prefabs;
    //velocidad de spawn y tiempo que ha pasado
    float spawnTime = 4f;
    
    float elapsedTime = 0f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//si el juego no ha terminado y no esta en pausa
        if (GameController.instance.gameOver == false) {
            if (PauseMenu.instance.GameState == false) { 
                if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            //crea el prefab
            GameObject randomPrefab;
            randomPrefab = prefabs[Random.Range(0,prefabs.Count)];
            Instantiate(randomPrefab, new Vector3(8.86f, -3.17f, 0), Quaternion.identity);
                
            elapsedTime = 0;
        }
	}
    }
}
}
