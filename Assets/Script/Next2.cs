using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class Next2 : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collider){
    Debug.Log("se tocan ");
    if(collider.CompareTag("Player"))
       {
    SceneManager.LoadScene("SceneM", LoadSceneMode.Single);
        }// escena nueva 
    }
}