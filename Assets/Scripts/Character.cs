using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    Animator anim;

    Rigidbody2D rb;
    float speed = 40f;
    float forcePush = 500f;
    
    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if(GameController.instance.gameOver == false) { 
        if (PauseMenu.instance.GameState == false)
        {
            
            float movX = Input.acceleration.x;
            rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
            anim.SetFloat("Speed", Mathf.Abs(movX));
            anim.SetBool("Grounded", true);
            if (Input.GetMouseButtonDown(0))
            {
                
                rb.AddForce(Vector2.up * forcePush);
                anim.SetBool("Grounded", false);
            }
        }
        
    }
        }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enviroment")
        {
            GameController.instance.gameOver = true;
            GameOver.instance.gameOverPanel.SetActive(true);
            PauseMenu.instance.button.SetActive(false);
        }


    }
}
