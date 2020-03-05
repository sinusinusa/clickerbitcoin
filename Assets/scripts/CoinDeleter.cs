using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinDeleter : MonoBehaviour
{
    public GameObject Coin;
    void Update()
    {
       if(Coin.transform.position.y < (-Screen.height/2)) {
            Destroy(Coin);
        }
    }
}
