using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {
    Animator anim;

    Rigidbody2D rb;
    float speed = 40f;
    float forcePush = 650f;
    private bool facingRight;
    public GameObject feet;
    public LayerMask layerMask;
    // Use this for initialization
    void Start () {
        facingRight = true;
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {

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
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enviroment")
        {
            GameController.instance.gameOver = true;
            GameOver.instance.gameOverPanel.SetActive(true);
            PauseMenu.instance.button.SetActive(false);
        }


    }
    private void movingX()
    {
        float movX = Input.acceleration.x;
        rb.transform.Translate(Vector2.right * speed * movX * Time.deltaTime);
        anim.SetFloat("Speed", Mathf.Abs(movX));
    }
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
