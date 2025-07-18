using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Muerte : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collider){
    Debug.Log("se tocan ");
    if(collider.CompareTag("Player"))
       {
    SceneManager.LoadScene("Level1", LoadSceneMode.Single);
        }// escena nueva 
    }
}