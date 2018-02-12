using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    Animator anim;

    Rigidbody2D rb;
    float speed = 10f;
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (PauseMenu.instance.GameState == false)
        {
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
            anim.SetFloat("Speed", Mathf.Abs(movX));
        }
        
    }
}
