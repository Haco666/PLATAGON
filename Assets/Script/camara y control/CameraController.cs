using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Player;
    void LateUpdate()
    { //queremos que pase despues del update pero dentro de lo que se conoce como runtime
        transform.position = Player.transform.position + new Vector3(1, 1, -1);// se le suma un vector 3
        //  que es el offset de la camara, son 3 parametros ya que aunque estemos en 2D la camara sigue 3D 
    }
}
