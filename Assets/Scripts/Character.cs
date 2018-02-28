using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Universidad del Valle de Guatemala
 * Marlon Fuentes - Jorge Azmitia
 * Funcion: Clase donde se encunetra el control del personaje. 
 */

public class Character : MonoBehaviour {
	
	//animator
    Animator anim;
//componentes
    Rigidbody2D rb;
	
	//velocidad, salto, monedas
    float speed = 40f;
    float forcePush = 650f;
	int coins=0;
    private bool facingRight;
    public GameObject feet;
    public LayerMask layerMask;
    // Use this for initialization
	
	//posicion, conseugir componentes y dar monedas obtenidas hasta el momento
    void Start () {
        facingRight = true;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
		coins =PlayerPrefs.GetInt("Coins");
    }
	
	// Update is called once per frame
	void Update () {
//si el juego no ha terminado y no esta en pausa, mover
        if(GameController.instance.gameOver == false) { 
        if (PauseMenu.instance.GameState == false)
        {
                float horizontal = Input.GetAxis("Horizontal");
                movingX();
                flip(horizontal);
                jumping();
            
          
        }
        
    }
        }
		
		//si choca contra algo de obstaculos, termina el juego y activa panel de final de juego
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enviroment")
        {
            GameController.instance.gameOver = true;
            GameOver.instance.gameOverPanel.SetActive(true);
            PauseMenu.instance.button.SetActive(false);
        }

		

    }
	//si colisiona con moneda, suma moneda, cambia playerprefs y borra la moneda
	private void OnTriggerEnter2D(Collider2D collision)
	{
	 if (collision.gameObject.tag == "Coin")
        {
          coins=coins+1;
		  PlayerPrefs.SetInt("Coins",coins);	
		  Destroy (GameObject.FindWithTag("Coin"));
        }
	}
//mueve el objeto	
    private void movingX()
    {
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        anim.SetFloat("Speed", Mathf.Abs(movX));
    }
	
	//funcion para saltar
    private void jumping()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D raycast = Physics2D.Raycast(feet.transform.position, Vector2.down, 0.1f, layerMask);
            if (raycast.collider != null)
            {
                rb.AddForce(Vector2.up * forcePush);
                anim.SetBool("Grounded", false);
            }
            
        }
    }
	
	//dar vuelta
    private void flip(float horizontal)
    {
        if(horizontal>0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
