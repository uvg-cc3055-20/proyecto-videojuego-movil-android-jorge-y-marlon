using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteBackground : MonoBehaviour {
    float scrollingSpeed = 5f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
