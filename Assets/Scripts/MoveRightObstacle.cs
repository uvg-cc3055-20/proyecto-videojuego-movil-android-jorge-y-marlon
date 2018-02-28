using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightObstacle : MonoBehaviour {
    Rigidbody2D rb;
    float speed = 5f;   
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
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
