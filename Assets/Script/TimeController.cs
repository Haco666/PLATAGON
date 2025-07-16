using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    public GameObject menuPausa;
    public float scaleAtRuntime;
    public void HandleTime()
    {
        if (Time.timeScale != 0)
        {
            Pause();
        }
        else
        {
            Resume();
        }
    }
    public void Pause()
    {
        scaleAtRuntime = Time.timeScale;
        Time.timeScale = 0;
        menuPausa.SetActive(true);
    }
    public void Resume()
    {
        Time.timeScale = scaleAtRuntime;
        menuPausa.SetActive(false);
    }
}