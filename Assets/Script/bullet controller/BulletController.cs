using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public Rigidbody2D rbBullet;
    public Vector2 direccion;
    public float force = 3;
    public int maxDistance = 10;
    public int Damage = 2;
    public GameObject Player;
    void Awake()
    {
        rbBullet = gameObject.GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void OnEnable()
    {
        rbBullet.velocity = new Vector2(30, direccion.y).normalized * force;
    }
    void FixedUpdate()
    {
        if (Mathf.Abs(rbBullet.position.x) > maxDistance)
        {
            gameObject.SetActive(false);
        }
    }
    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            gameObject.SetActive(false);
            collider.gameObject.GetComponent<EnemyController>().life -= Damage;
        }
    }
}