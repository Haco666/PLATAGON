using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public EnemyStats enemyStats;
    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player"))
        {
            collider.GetComponent<PlayerController>().Life -= enemyStats.Damage; //coge el damage de enemy stats
            if (collider.transform.position.x > gameObject.transform.position.x)
            {
                Debug.Log("here");
                collider.GetComponent<Rigidbody2D>().velocity = new Vector2(10, 5);
            }
            else if (collider.transform.position.x < gameObject.transform.position.x)
            {
                Debug.Log("there");
                collider.GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 5);
            }
        }
    }
}