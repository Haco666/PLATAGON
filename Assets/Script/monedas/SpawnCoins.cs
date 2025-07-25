using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoins : MonoBehaviour
{
    public GameObject coinPool;
    public float x;
    public float y;

    void Start()
    {
        StartCoroutine(Spawn());
    }
    public IEnumerator Spawn()
    {
        yield return new WaitForSeconds(3);
        GameObject coin = coinPool.GetComponent<CoinPool>().GetPooledObject();
        if (coin != null)
        {
            //alta pantalla 160.8 60.2 y baja pantalla 360.8 11.7
            x = Random.Range(160.8f, 60.2f);
            y = Random.Range(360.8f, -3.85f);
            coin.transform.position = new Vector3(x, y, 0);
            coin.SetActive(true);
        }
        StartCoroutine(Spawn());
    }
}