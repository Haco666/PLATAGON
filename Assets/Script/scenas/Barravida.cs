using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Image barraDeVida;
    public PlayerStats playerStats;
    public GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    

    void Update()
    {
        barraDeVida.fillAmount = player.GetComponent<PlayerController>().Life / playerStats.MaxLife;
    }
}