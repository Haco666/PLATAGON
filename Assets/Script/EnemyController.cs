using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject puntoA;
    public GameObject puntoB;
    public Transform currentPoint;
    public EnemyStats enemyStats;
    public float life;
    public float damage;
    public float speed;
    void Awake()
    {
        life = enemyStats.MaxLife;
        damage = enemyStats.Damage;
        speed = enemyStats.Speed;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = puntoA.transform;
    }
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == puntoB.transform)
        {
            rb.velocity = new Vector2(speed, 0); //x,y,z
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.9f && currentPoint == puntoB.transform)
        {
            currentPoint = puntoA.transform;
        }
        else if (Vector2.Distance(transform.position, currentPoint.position) < 0.9f && currentPoint == puntoA.transform)
        {
            currentPoint = puntoB.transform;
        }
        if (life <= 0)
        {
            Destroy(gameObject); //desaparece el enemigo
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(puntoA.transform.position, 10f);
        Gizmos.DrawWireSphere(puntoB.transform.position, 10f);
        Gizmos.DrawLine(puntoA.transform.position, puntoB.transform.position);
    }
}