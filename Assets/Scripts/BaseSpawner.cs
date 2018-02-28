using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawner : MonoBehaviour {

    public List<GameObject> prefabs;
    
    float spawnTime = 4f;
    
    float elapsedTime = 0f;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gameOver == false) {
            if (PauseMenu.instance.GameState == false) { 
                if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            
            GameObject randomPrefab;
            randomPrefab = prefabs[Random.Range(0,prefabs.Count)];
            Instantiate(randomPrefab, new Vector3(8.86f, -3.17f, 0), Quaternion.identity);
                
            elapsedTime = 0;
        }
	}
    }
}
}
