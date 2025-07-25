using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataLado : MonoBehaviour
{
    public float speed = 10f;
    public Rigidbody2D rb;
    public GameObject puntoA;
    public GameObject puntoB;
    public Transform currentPoint;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = puntoA.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;
        if (currentPoint == puntoA.transform)
        {
            rb.velocity = new Vector2(speed, 0);// x, y, z
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
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(puntoA.transform.position, 0.5f);
        Gizmos.DrawWireSphere(puntoB.transform.position, 0.5f);
        Gizmos.DrawLine(puntoA.transform.position, puntoB.transform.position);
    }
}