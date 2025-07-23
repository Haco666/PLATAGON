using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public InventoryStats inventoryStats;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            inventoryStats.Coins += 1; //suma 1
            gameObject.SetActive(false);
        }
    }
}