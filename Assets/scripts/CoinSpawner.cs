using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public Vector3 start_position = new Vector3();
    public GameObject coinSpawner;
    public GameObject coin;
    public void Spawner()
    {
        float x = Random.Range(-8, 8);
        coinSpawner.transform.position = new Vector3(x, coinSpawner.transform.position.y);
        Instantiate(coin, coinSpawner.transform.position, Quaternion.identity);
    }
}
