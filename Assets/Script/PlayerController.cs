using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; // declaramos la velocidad
    public float speedJump; // velocidad salto
    private Rigidbody2D playerb;
    public float inputMovimiento;
    public bool IsGrounded;
    public GroundedController gc;
    // Start is called before the first frame update

    void Start()
    {
        playerb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = gc.IsGrounded();
        ProcesarMovimiento();
    }
    void ProcesarMovimiento()
    {
        inputMovimiento = Input.GetAxis("Horizontal");
        playerb.velocity = new Vector2(inputMovimiento * speed, playerb.velocity.y);
        //aqui se aÃ±aden animaciones anim.SetBool("Walking", true);
    }

    private void FixedUpdate()
    {

        if (Input.GetKey("d"))
        {
            playerb.AddForce(transform.right * speed);
        }
        else if (Input.GetKey("a"))
        {
            playerb.AddForce(transform.right * -speed);
        }
        else if (Input.GetKey("w"))
        {
            playerb.AddForce(transform.up * speed);
        }
        else if (Input.GetKey("s"))
        {
            playerb.AddForce(transform.up * -speed);
        }
        if (Input.GetKey("space") && gc.IsGrounded())
        {
            playerb.AddForce(transform.up * speedJump);
            Debug.Log("salto?");
        }
    }
}