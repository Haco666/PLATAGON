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
            //alta pantalla -11.14 1.16 y baja pantalla 21.57 -3.85
            x = Random.Range(-11.14f, 21.57f);
            y = Random.Range(1.16f, -3.85f);
            coin.transform.position = new Vector3(x, y, 0);
            coin.SetActive(true);
        }
        StartCoroutine(Spawn());
    }
}