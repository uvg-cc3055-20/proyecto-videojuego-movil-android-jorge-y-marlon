using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase que tiene el spawn 
 */

public class SpawnerRight : MonoBehaviour {
    public List<GameObject> prefabsRight;
	
	//tiempo de spawn y pasado
    float spawnTimeRight = 20f;
    float elapseTimeRight = 0f;
    int firstTime = 0;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
		
		//si el juego no ha terminado 
        if (GameController.instance.gameOver == false)
        {
			
			//si no esta en pausa
            if (PauseMenu.instance.GameState == false) { 
			
			//si no se tiene que resetear suma el tiempo
                if (elapseTimeRight < spawnTimeRight)
            {
                elapseTimeRight += Time.deltaTime;
                

            }
			
			//crea objeto prefab
            else
            {
                firstTime += 1;
                GameObject randomPrefabRight;
                randomPrefabRight = prefabsRight[Random.Range(0, prefabsRight.Count)];
                //float random = Random.Range(-8f, 8f);
                Instantiate(randomPrefabRight, new Vector3(-8.86f, -3.17f, 0), Quaternion.identity);
                if (firstTime == 1)
                {
                    spawnTimeRight -= 15f;
                }
                elapseTimeRight = 0;

            }
        }
    }
}
}
