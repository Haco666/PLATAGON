using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class SceneM : MonoBehaviour
{
    // Start is called before the first frame update
    public void Play()
    {
        SceneManager. LoadScene("Level1", LoadSceneMode.Single);        
        
    }
    public void BackMenu()
    {
        SceneManager. LoadScene("Menu", LoadSceneMode.Single);        
        
    }
}
