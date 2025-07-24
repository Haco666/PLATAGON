using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallThroughPlatform : MonoBehaviour
{
    private PlatformEffector2D effector;
    public float timeToFallThrough = 5f;
    public float dropDuration = 0.5f;

    private bool isFalling = false;
    private bool playerOnPlatform = false;

    void Start()
    {
        effector = GetComponent<PlatformEffector2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerOnPlatform = true;

            if (!isFalling)
            {
                StartCoroutine(DelayedFallThrough());
            }
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            playerOnPlatform = false;
        }
    }

    private IEnumerator DelayedFallThrough()
    {
        isFalling = true;

        yield return new WaitForSeconds(timeToFallThrough);

        effector.rotationalOffset = 180f;

        yield return new WaitForSeconds(dropDuration);

        effector.rotationalOffset = 0f;
        isFalling = false;
    }
}