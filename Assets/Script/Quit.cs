using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
   public void ExitGame()
    {
        // If we are running in a standalone build of the game
        Application.Quit();
        Debug.Log("ya esta bien XD");
        
    }
}
