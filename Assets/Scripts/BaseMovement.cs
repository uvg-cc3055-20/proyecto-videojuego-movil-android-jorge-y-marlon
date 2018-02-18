using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour {

    Rigidbody2D rb;
    float speed = 5f;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (rb.transform.position.x <-3f)
        {
            Destroy(gameObject);
        }
	}
}
