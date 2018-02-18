using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSpawner : MonoBehaviour {

    public List<GameObject> prefabs;
    public List<GameObject> prefabsRight;
    float spawnTime = 4f;
    float elapsedTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameController.instance.gameOver == false) { 
            if (elapsedTime < spawnTime)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            
            GameObject randomPrefab;
            randomPrefab = prefabs[Random.Range(0,prefabs.Count)];
            GameObject randomPrefabRight;
            randomPrefabRight = prefabsRight[Random.Range(0, prefabsRight.Count)];
            //float random = Random.Range(-8f, 8f);
            Instantiate(randomPrefabRight,  new Vector3(-7f, -4f, 0), Quaternion.identity);
            Instantiate(randomPrefab, new Vector3(8.66f, -4f, 0), Quaternion.identity);
            elapsedTime = 0;
        }
	}
    }
}
