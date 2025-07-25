using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedController : MonoBehaviour
{
    public float distToGround; //Distancia suelo
    public bool helper;
    public int layer;
    public int layerMask;

    void Start()
    {
        distToGround = GetComponent<Collider2D>().bounds.extents.y;
        layer = 6;
        layerMask = 1 << layer;
    }
    public bool IsGrounded()
    {
        Debug.DrawRay(transform.position, -Vector3.up, Color.yellow); // dibuja el rayo
        return Physics2D.Raycast(transform.position, -Vector3.up, distToGround + 2f, layerMask);
    }
    void FixedUpdate()
    {
        IsGrounded();
        helper = IsGrounded();
    }

}