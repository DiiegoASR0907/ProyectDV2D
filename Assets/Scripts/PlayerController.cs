using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody2D RB;
    bool facingRight = true;
    SpriteRenderer myRender;
    Animator Anim;

    bool canMove = true;
    // saltar
    bool grounded = false;
    float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    public Transform groundCheck;
    public float jumpPower;
    // movimiento
    public float maxSpeed;
	// Una vez con el inicio de vida del objeto
	void Start () {
        RB = GetComponent<Rigidbody2D>();
        myRender = GetComponent<SpriteRenderer>();
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        // darle movimiento a la derecha o izquierda con pulsación de teclado
        float move = Input.GetAxis("Horizontal");

        if (canMove && grounded && Input.GetAxis("Jump") > 0)
        {
            Anim.SetBool("isGrounded", false);
            RB.velocity = new Vector2(RB.velocity.x, 0f);
            RB.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            grounded = false;
        }
        grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, groundLayer);
        Anim.SetBool("isGrounded", grounded);

        //condicion para girar el personaje con direccion del teclado
        if (canMove) { 
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();
        // dar velocidad, crear vector 2 ejes (x,y)
        RB.velocity = new Vector2(move * maxSpeed, RB.velocity.y);
        Anim.SetFloat("MoveSpeed", Mathf.Abs(move));
	    }
        else
        {
            RB.velocity = new Vector2(0, RB.velocity.y);
            Anim.SetFloat("MoveSpeed", 0);
        }
    }
    // Crear funcion Flip (llamar resto de funciones)
    void Flip()
    {
        facingRight = !facingRight;
        myRender.flipX = !myRender.flipX;
    }
    public void toggleCanMove()
    {
        canMove = !canMove;
    }
}
