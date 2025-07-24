using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    public InventoryStats inventory;

    public int toOpen;

    void Update()

    {
        if (inventory.Coins >= toOpen)
        {
            gameObject.SetActive(false);
        }
    }
}
