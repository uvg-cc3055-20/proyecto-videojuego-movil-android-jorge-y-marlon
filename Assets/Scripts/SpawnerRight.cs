using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRight : MonoBehaviour {
    public List<GameObject> prefabsRight;
    float spawnTimeRight = 20f;
    float elapseTimeRight = 0f;
    int firstTime = 0;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (GameController.instance.gameOver == false)
        {
            if (PauseMenu.instance.GameState == false) { 
                if (elapseTimeRight < spawnTimeRight)
            {
                elapseTimeRight += Time.deltaTime;
                

            }
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
