using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerb;
    public float inputMovimiento;
    public bool IsGrounded;
    public GroundedController gc;
    public PlayerStats playerStats;
    public float Life;
    public float speed; // declaramos la velocidad
    public float speedJump; // velocidad salto
    void Start()
    {
        playerb = GetComponent<Rigidbody2D>();
        Life = playerStats.MaxLife;
        speed = playerStats.Speed;
        speedJump = playerStats.SpeedJump;
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded = gc.IsGrounded();
        ProcesarMovimiento();
        if (Life <= 0)
        {
            Die();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Shoot();
        }
    }
    void ProcesarMovimiento()
    {
        inputMovimiento = Input.GetAxis("Horizontal");
        playerb.velocity = new Vector2(inputMovimiento * speed, playerb.velocity.y);
        //aqui se añaden animaciones anim.SetBool("Walking", true);
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
        /*   else if (Input.GetKey("w"))
        {
            playerb.AddForce(transform.up * speed);
        }
        else if (Input.GetKey("s"))
        {
            playerb.AddForce(transform.up * -speed);
        }*/
        if (Input.GetKey("space") && gc.IsGrounded())
        {
            playerb.AddForce(transform.up * speedJump);
            Debug.Log("salto?");
        }
    }
    public void Shoot()
    {
        GameObject bullet = BulletPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            bullet.transform.position = playerb.transform.position;
            bullet.transform.rotation = playerb.transform.rotation;
            if (Time.timeScale != 0)
            {
                bullet.SetActive(true);
            }
        }
    }
    public void Die()
    {
        gameObject.SetActive(false);
        //cambia de escena o repones la misma SceneManager.LoadScene("cualquiercosa", LoadSceneMode.Single);
        //añadir pantallita de muerte
        Debug.Log("me mueri");
    }
}